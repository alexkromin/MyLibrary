using System;
using System.Collections.Generic;

namespace MyLibrary
{
    public static class EnumerableExtension
    {
        public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source, int count)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (count < 0) 
                throw new ArgumentOutOfRangeException("count");
            var array = new TSource[count];
            int i = 0;
            foreach (var item in source)
            {
                array[i++] = item;
            }
            if (i != count)
                throw new ArgumentOutOfRangeException();
            return array;
        }

        public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source, int count)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            var list = new List<TSource>(count);
            foreach (var item in source)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
