using System;

namespace System
{
    static class RandomExtensions
    {
        public static T Next<T>(this Random rnd, params T[] items)
        {
            return items[rnd.Next(items.Length)];
        }
    }
}
