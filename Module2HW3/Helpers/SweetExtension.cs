using Module2HW3.Models;

namespace Module2HW3.Helpers
{
    public static class SweetExtension
    {
        public static Sweet GetChocolate(this Sweet sweet, ChocolateType type)
        {
            var chocolate = sweet as Chocolate;
            if (chocolate == null)
            {
                return null;
            }

            if (chocolate.TypeChocolate == type)
            {
                return chocolate;
            }

            return null;
        }

        public static Sweet GetWithFillerChocolate(this Sweet sweet, ChocolateType chocolateType, string filler)
        {
            var chocolate = sweet as WithFillerChocolate;
            if (chocolate == null)
            {
                return null;
            }

            if (chocolate.TasteOfFiller.Contains(filler) && chocolate.TypeChocolate == chocolateType)
            {
                return chocolate;
            }

            return null;
        }

        public static Sweet GetWithNutsChocolate(this Sweet sweet, ChocolateType chocolateType, string nut)
        {
            var chocolate = sweet as WithNutsChocolate;
            if (chocolate == null)
            {
                return null;
            }

            foreach (var nutInChokolate in chocolate.Nuts)
            {
                if (nutInChokolate.Contains(nut) && chocolate.TypeChocolate == chocolateType)
                {
                    return chocolate;
                }
            }

            return null;
        }

        public static Sweet GetWithNutsGlazedCandy(this Sweet sweet, GlazeType glazeType, string nut)
        {
            var candy = sweet as WithNutsGlazedCandy;
            if (candy == null)
            {
                return null;
            }

            foreach (var nutInCandy in candy.Nuts)
            {
                if (nutInCandy.Contains(nut) && candy.TypeGlaze == glazeType)
                {
                    return candy;
                }
            }

            return null;
        }

        public static Sweet GetWithFillerGlazedCandy(this Sweet sweet, GlazeType glazeType, string filler)
        {
            var candy = sweet as WithFillerGlazedCandy;
            if (candy == null)
            {
                return null;
            }

            if (candy.Filler.Contains(filler) && candy.TypeGlaze == glazeType)
            {
                return candy;
            }

            return null;
        }

        public static Sweet GetChocolateGlazedCandy(this Sweet sweet, GlazeType glazeType, ChocolateType chocolateType)
        {
            var candy = sweet as ChocolateGlazedCandy;
            if (candy == null)
            {
                return null;
            }

            if (candy.TypeChocolate == chocolateType && candy.TypeGlaze == glazeType)
            {
                return candy;
            }

            return null;
        }

        public static Sweet GetWithFillerChocolateGlazedCandy(this Sweet sweet, GlazeType glazeType, ChocolateType chocolateType, string filler)
        {
            var candy = sweet as WithFillerChocolateGlazedCandy;
            if (candy == null)
            {
                return null;
            }

            if (candy.Filler.Contains(filler) && candy.TypeGlaze == glazeType && candy.TypeChocolate == chocolateType)
            {
                return candy;
            }

            return null;
        }

        public static Sweet GetWithNutsChocolateGlazedCandy(this Sweet sweet, GlazeType glazeType, ChocolateType chocolateType, string nut)
        {
            var candy = sweet as WithNutsChocolateGlazedCandy;
            if (candy == null)
            {
                return null;
            }

            foreach (var nutInCandy in candy.Nuts)
            {
                if (nutInCandy.Contains(nut) && candy.TypeGlaze == glazeType && candy.TypeChocolate == chocolateType)
                {
                    return candy;
                }
            }

            return null;
        }

        public static Sweet GetSweetByPrice(this Sweet sweet, double minPrice, double maxPrice)
        {
            if (sweet == null)
            {
                return null;
            }

            if (sweet.Price >= minPrice && sweet.Price <= maxPrice)
            {
                return sweet;
            }

            return null;
        }
    }
}
