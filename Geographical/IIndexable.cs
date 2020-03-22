using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NeoSmart.Data.Geographical
{
    public interface IIndexable
    {
    }

    public interface IIndexable<T> : IIndexable
    {
        //T Find<K>(Expression<Func<T, K>> expression, K value);
    }

    static class Indexer<X, T,K>
        where X : IIndexable<T>
    {
        // This is always a new type, which is an improvement.. I guess
        //static Dictionary<K, T> GetExpressionIndex<TDelegate>(TDelegate expression)
        //{
        //    var type = typeof(ExpressionIndex<, , ,>).MakeGenericType(typeof(IIndexable<T>), typeof(T), typeof(TDelegate), typeof(K));
        //    var x = ((IExpressionIndex<T, K>)Activator.CreateInstance(type));
        //    return x.Index;
        //}

        static Dictionary<K, T> GetExpressionIndex(Type t)
        {
            var type = typeof(ExpressionIndex<,,,>).MakeGenericType(typeof(IIndexable<T>), typeof(T), t, typeof(K));
            var x = ((IExpressionIndex<T, K>)Activator.CreateInstance(type));
            return x.Index;
        }

        public static void Build(Dictionary<K, T> index, IEnumerable<T> indexable, Expression<Func<T, K>> expression)
        {
            var accessor = expression.Compile();

            foreach (var t in indexable)
            {
                index.Add(accessor(t), t);
            }
        }

        static Dictionary<Type, Dictionary<K, T>> Indexes = new Dictionary<Type, Dictionary<K, T>>();
        public static T Find(IEnumerable<T> indexable, Expression<Func<T, K>> expression, K key)
        {
            var compiled = expression.Compile();
            var compiled2 = ((LambdaExpression)expression).Compile();
            Expression reduced = expression;


            while (reduced.CanReduce)
            {
                reduced = reduced.Reduce();
            }
#if NETSTANDARD1_3
    var index = new Dictionary<K,T>();
#else
            //var index = GetExpressionIndex(reduced.NodeType.GetType());
            Dictionary<K, T> index;
            var search = expression.Type;
            if (!Indexes.TryGetValue(search, out index))
            {
                index = new Dictionary<K, T>();
                Indexes.Add(search, index);
            }
#endif

            if (index.Count == 0)
            {
                lock (index)
                {
                    if (index.Count == 0)
                    {
                        Build(index, indexable, expression);
                    }
                }
            }
            return index[key];
        }
    }

    interface IExpressionIndex<T, K>
    {
        Dictionary<K, T> Index { get; }
    }

    struct ExpressionIndex<X, T, E, K> : IExpressionIndex<T, K>
        where X : IIndexable<T>
    {
        static E e;
        static readonly Dictionary<K, T> InnerIndex = new Dictionary<K, T>();
        public Dictionary<K, T> Index => InnerIndex;
    }
}
