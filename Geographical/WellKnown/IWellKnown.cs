using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NeoSmart.Data.Geographical
{
    public abstract class WellKnown<T> : IIndexable<T>, IEnumerable<T>
        where T: IComparable<T>, IEquatable<T>
    {
        static readonly SortedSet<T> _found = new SortedSet<T>();

        public static SortedSet<T> All
        {
            get => _found.Count == 0 ? FindInstances() : _found;
        }

        static SortedSet<T> FindInstances()
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
                    if (assembly.FullName.StartsWith("System."))
                    {
                        continue;
                    }

                    foreach (var type in assembly.GetTypes())
                    {
#if !NETSTANDARD1_3
                        if (type.IsInterface)
                        {
                            continue;
                        }
#endif

                        var fields = type.GetFields(
                            (BindingFlags.Static | BindingFlags.FlattenHierarchy | BindingFlags.Public)
                            & ~(BindingFlags.NonPublic));

                        foreach (var field in fields)
                        {
                            if (field.FieldType == typeof(T))
                            {
                                var instance = (T)field.GetValue(null); // null because we are only looking at static instances
                                _found.Add(instance);
                            }

                            foreach (var innerField in field.FieldType.GetFields())
                            {
                                object instance = null;
                                if (innerField.FieldType == typeof(T))
                                {
                                    if (instance == null)
                                    {
                                        instance = field.GetValue(null);
                                    }
                                    _found.Add((T)innerField.GetValue(instance));
                                }
                            }
                        }
                    }
                }

                return _found;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)All).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)All).GetEnumerator();
        }

        //public static T Find<K>(System.Linq.Expressions.Expression<Func<T, K>> expression, K value)
        //{
        //    return Indexer<WellKnown<T>, T, K>.Find(All, expression, value);
        //}
    }
}
