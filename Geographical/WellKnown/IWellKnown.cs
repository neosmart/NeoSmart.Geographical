using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace NeoSmart.Geographical
{
    public abstract class WellKnown<T> : IEnumerable<T>
        where T: struct, IComparable<T>, IEquatable<T>
    {
        private static TypeIndexer<T, WellKnown<T>>? _all;
        private static PropertyIndexer<T, string>? _indexer;

        protected abstract IEnumerable<Expression<Func<T, string>>> IndexExpressions { get; }

        private void BuildIndex()
        {
            _all ??= new TypeIndexer<T, WellKnown<T>>();
            _indexer = new PropertyIndexer<T, string>(StringComparer.CurrentCultureIgnoreCase);
            foreach (var expression in IndexExpressions)
            {
                _indexer.AddToIndex(_all, expression, key => !string.IsNullOrEmpty(key));
            }
        }

        public T? Find(string search)
        {
            if (TryGetValue(search, out var result))
            {
                return result;
            }
            return null;
        }

        public bool TryGetValue(string search, out T result)
        {
            if (_indexer is null)
            {
                BuildIndex();
            }

            return _indexer!.Index.TryGetValue(search, out result);
        }

        public IEnumerator<T> GetEnumerator()
        {
            _all ??= new TypeIndexer<T, WellKnown<T>>();
            return _all.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class TypeIndexer<T, ParentType> : IEnumerable, IEnumerable<T>
    {
        static readonly SortedSet<T> _found = new SortedSet<T>();

        static TypeIndexer()
        {
            FindInstances(typeof(ParentType));
        }

        static SortedSet<T> FindInstances(Type? containerType = null)
        {
            lock (_found)
            {
                if (_found.Count > 0)
                {
                    return _found;
                }

                var assemblies = AppDomain.CurrentDomain.GetAssemblies();
                foreach (var assembly in assemblies)
                {
                    //if (assembly.FullName.StartsWith("System.")
                    //    || assembly.FullName.StartsWith("Microsoft."))
                    if (!assembly.FullName.StartsWith("NeoSmart.Geographical"))
                    {
                        continue;
                    }

                    foreach (var type in assembly.GetTypes())
                    {
#if !NETSTANDARD1_3
                        if (containerType is object
                            && !type.IsSubclassOf(containerType))
                        {
                            continue;
                        }
#endif

                        var staticProperties = type.GetProperties(
                            (BindingFlags.Static) & ~(BindingFlags.NonPublic));
                        foreach (var property in staticProperties)
                        {
                            if (property.PropertyType == typeof(T))
                            {
                                var result = property.GetValue(null);
                                _found.Add((T)result);
                            }
                        }

                        object? instance = null;
                        bool makeInstance()
                        {
                            var constructor = type.GetConstructor(Type.EmptyTypes);
                            if (constructor is null)
                            {
                                // No default constructor available
                                return false;
                            }
                            instance = constructor.Invoke(Array.Empty<Object>());
                            return instance is object && true;
                        }

                        var properties = type.GetProperties(
                            ((BindingFlags)(-1)) & ~(BindingFlags.Static | BindingFlags.NonPublic));
                        foreach (var property in properties)
                        {
                            if (property.PropertyType == typeof(T))
                            {
                                if (instance is null && !makeInstance())
                                {
                                    break;
                                }
                                var result = property.GetValue(instance);
                                _found.Add((T)result);
                            }
                        }

                        var staticFields = type.GetFields(
                            (BindingFlags.Static) & ~(BindingFlags.NonPublic));
                        foreach (var field in staticFields)
                        {
                            if (field.FieldType == typeof(T))
                            {
                                var value = (T)field.GetValue(null);
                                _found.Add(value);
                            }

                            object? fieldInstance = null;
                            foreach (var innerField in field.FieldType.GetFields())
                            {
                                if (innerField.FieldType == typeof(T))
                                {
                                    fieldInstance ??= field.GetValue(null);
                                    _found.Add((T)innerField.GetValue(fieldInstance));
                                }
                            }
                        }

                        //var fields = type.GetFields(
                        //    ~(BindingFlags.Static | BindingFlags.NonPublic));
                        //foreach (var field in staticFields)
                        //{
                        //    object? fieldInstance = null;
                        //    if (field.FieldType == typeof(T))
                        //    {
                        //        instance ??= makeInstance();
                        //        fieldInstance = field.GetValue(instance);
                        //        _found.Add((T)fieldInstance);
                        //    }

                        //    foreach (var innerField in field.FieldType.GetFields())
                        //    {
                        //        if (innerField.FieldType == typeof(T))
                        //        {
                        //            instance ??= makeInstance();
                        //            fieldInstance ??= field.GetValue(null);
                        //            _found.Add((T)innerField.GetValue(fieldInstance));
                        //        }
                        //    }
                        //}
                    }
                }

                return _found;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_found).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)_found).GetEnumerator();
        }

        //public static T Find<K>(System.Linq.Expressions.Expression<Func<T, K>> expression, K value)
        //{
        //    return Indexer<WellKnown<T>, T, K>.Find(All, expression, value);
        //}
    }
}
