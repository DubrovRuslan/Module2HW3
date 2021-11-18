using System.Collections.Generic;
using Module2HW3.Models;

namespace Module2HW3.Helpers
{
    public class ChocolateComparer : IComparer<Sweet>
    {
        public int Compare(Sweet sweet1, Sweet sweet2)
        {
            var chocolate1 = sweet1 as Chocolate;
            var chocolate2 = sweet2 as Chocolate;
            if (chocolate1 == null || chocolate2 == null)
            {
                return 0;
            }

            if (chocolate1.TypeChocolate < chocolate2.TypeChocolate)
            {
                return 1;
            }
            else if (chocolate1.TypeChocolate > chocolate2.TypeChocolate)
            {
                return -1;
            }

            return 0;
        }
    }
}
