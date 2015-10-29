using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public static class Extention
    {
        public static T FirstOrDefaul<T>(this IEnumerable<T> collection, Predicate<T> preicate)
        {
            foreach (var item in collection)
            {
                if (preicate(item))
                {
                    return item;
                }
            }
            return default(T);
        }

        public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> collection, Func<T, bool> preicate)
        {
            List<T> whileList = new List<T>();

            foreach (var item in collection)
            {
                if (preicate(item))
                {
                    whileList.Add(item);
                }
                else
                {
                    break;
                }
            }
            return whileList;
        }

        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }

        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T,bool> preicate)
        {
            List<T> matches = new List<T>();

            foreach (var item in collection)
            {
                if (!preicate(item))
                {
                    matches.Add(item);
                }
            }
            return matches;
        }

        public static T Max<K, T>(this IEnumerable<K> collection, Func<K, T> predicate) where T : IComparable
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection","collection given in the Max predicate is empty");
            }

            T max = predicate(collection.First());

            foreach (K item in collection)
            {
                if (predicate(item).CompareTo(max) > 0)
                {
                    max = predicate(item);
                }
            }
            return max;
        }


    }
}
