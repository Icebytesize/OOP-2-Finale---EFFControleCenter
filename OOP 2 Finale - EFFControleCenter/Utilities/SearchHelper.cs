using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_Finale___EFFControleCenter.Utilities
{
    internal static class SearchHelper
    {

        public static List<T> Filter<T>(IEnumerable<T> items, Func<T, bool> predicate)
        {
            return items.Where(predicate).ToList();
        }
        
    }
}
