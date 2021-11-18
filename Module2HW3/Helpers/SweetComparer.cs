using System;
using System.Collections.Generic;
using Module2HW3.Models;

namespace Module2HW3.Helpers
{
    public class SweetComparer : IComparer<Sweet>
    {
        public int Compare(Sweet sweet1, Sweet sweet2)
        {
            return string.Compare(sweet1.Name, sweet2.Name);
        }
    }
}
