using System;
using System.Collections.Generic;

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
    }
}
