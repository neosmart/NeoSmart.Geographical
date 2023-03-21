using System;
using System.Collections.Generic;

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

        public void AddToIndex(IEnumerable<TEntity> entities, Func<TEntity, TKey> indexer,
            Func<TKey, bool>? precondition = null)
        {
            precondition ??= static _ => true;
            foreach (var entity in entities)
            {
                var key = indexer(entity);
                if (precondition(key))
                {
#if NETSTANDARD2_1_OR_GREATER
                    Index.TryAdd(key, entity);
#else
                    try
                    {
                        Index[key] = entity;
                    }
                    catch
                    {
                    }
#endif
                }
            }
        }
    }
}
