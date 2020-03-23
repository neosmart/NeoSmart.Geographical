using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NeoSmart.Geographical
{
    internal class PropertyIndexer<TEntity, TKey>
    {
        public SortedDictionary<TKey, TEntity> Index;

        public PropertyIndexer(IComparer<TKey>? comparer = null)
        {
            comparer ??= Comparer<TKey>.Default;
            Index = new SortedDictionary<TKey, TEntity>(comparer);
        }

        public void AddToIndex(IEnumerable<TEntity> entities, Expression<Func<TEntity, TKey>> indexer,
            Func<TKey, bool>? precondition = null)
        {
            precondition ??= _ => true;
            var compiled = indexer.Compile();
            foreach (var entity in entities)
            {
                var key = compiled(entity);
                if (precondition(key))
                {
                    Index[compiled(entity)] = entity;
                }
            }
        }
    }
}
