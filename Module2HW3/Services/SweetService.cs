using System;
using Module2HW3.Providers;
using Module2HW3.Models;
using Module2HW3.Helpers;

namespace Module2HW3.Services
{
    public class SweetService
    {
        private SweetProvider _sweetProvider = new SweetProvider();
        private Random _random = new Random();
        public void AddChocolate(string name, double price, double weight, ChocolateType chocolateType)
        {
            _sweetProvider.AddSweet(new Chocolate
            {
                Name = name,
                Price = price,
                Weight = weight,
                TypeChocolate = chocolateType
            });
        }

        public void AddWithFillerChocolate(string name, double price, double weight, ChocolateType chocolateType, string filler)
        {
            _sweetProvider.AddSweet(new WithFillerChocolate
            {
                Name = name,
                Price = price,
                Weight = weight,
                TypeChocolate = chocolateType,
                TasteOfFiller = filler
            });
        }

        public void AddWithNutsChocolate(string name, double price, double weight, ChocolateType chocolateType, string[] nuts)
        {
            _sweetProvider.AddSweet(new WithNutsChocolate
            {
                Name = name,
                Price = price,
                Weight = weight,
                TypeChocolate = chocolateType,
                Nuts = nuts
            });
        }

        public void AddChocolateGlazedCandy(string name, double price, double weight, ChocolateType chocolateType, GlazeType glazeType)
        {
            _sweetProvider.AddSweet(new ChocolateGlazedCandy
            {
                Name = name,
                Price = price,
                Weight = weight,
                TypeChocolate = chocolateType,
                TypeGlaze = glazeType
            });
        }

        public void AddWithFillerChocolateGlazedCandy(string name, double price, double weight, ChocolateType chocolateType, GlazeType glazeType)
        {
            _sweetProvider.AddSweet(new WithFillerChocolateGlazedCandy
            {
                Name = name,
                Price = price,
                Weight = weight,
                TypeChocolate = chocolateType,
                TypeGlaze = glazeType
            });
        }

        public void AddWithFillerGlazedCandy(string name, double price, double weight, GlazeType glazeType, string filler)
        {
            _sweetProvider.AddSweet(new WithFillerGlazedCandy
            {
                Name = name,
                Price = price,
                Weight = weight,
                TypeGlaze = glazeType,
                Filler = filler
            });
        }

        public void AddWithNutsChocolateGlazedCandy(string name, double price, double weight, ChocolateType chocolateType, GlazeType glazeType, string[] nuts)
        {
            _sweetProvider.AddSweet(new WithNutsChocolateGlazedCandy
            {
                Name = name,
                Price = price,
                Weight = weight,
                TypeChocolate = chocolateType,
                TypeGlaze = glazeType,
                Nuts = nuts
            });
        }

        public void AddWithNutsGlazedCandy(string name, double price, double weight, GlazeType glazeType, string[] nuts)
        {
            _sweetProvider.AddSweet(new WithNutsGlazedCandy
            {
                Name = name,
                Price = price,
                Weight = weight,
                TypeGlaze = glazeType,
                Nuts = nuts
            });
        }

        public Sweet[] GetChocolate(ChocolateType chocolateType)
        {
            var sweets = _sweetProvider.GetAllSweets();
            Sweet[] result = null;
            foreach (var sweet in sweets)
            {
                ArrayHelper.AddElementToArray(ref result, sweet.GetChocolate(chocolateType));
            }

            return result;
        }

        public Sweet[] GetWithFillerChocolate(ChocolateType chocolateType, string filler)
        {
            var sweets = _sweetProvider.GetAllSweets();
            Sweet[] result = null;
            foreach (var sweet in sweets)
            {
                ArrayHelper.AddElementToArray(ref result, sweet.GetWithFillerChocolate(chocolateType, filler));
            }

            return result;
        }

        public Sweet[] GetWithNutsChocolate(ChocolateType chocolateType, string nut)
        {
            var sweets = _sweetProvider.GetAllSweets();
            Sweet[] result = null;
            foreach (var sweet in sweets)
            {
                ArrayHelper.AddElementToArray(ref result, sweet.GetWithNutsChocolate(chocolateType, nut));
            }

            return result;
        }

        public Sweet[] GetWithNutsGlazedCandy(GlazeType glazeType, string nut)
        {
            var sweets = _sweetProvider.GetAllSweets();
            Sweet[] result = null;
            foreach (var sweet in sweets)
            {
                ArrayHelper.AddElementToArray(ref result, sweet.GetWithNutsGlazedCandy(glazeType, nut));
            }

            return result;
        }

        public Sweet[] GetWithFillerGlazedCandy(GlazeType glazeType, string filler)
        {
            var sweets = _sweetProvider.GetAllSweets();
            Sweet[] result = null;
            foreach (var sweet in sweets)
            {
                ArrayHelper.AddElementToArray(ref result, sweet.GetWithFillerGlazedCandy(glazeType, filler));
            }

            return result;
        }

        public Sweet[] GetChocolateGlazedCandy(GlazeType glazeType, ChocolateType chocolateType)
        {
            var sweets = _sweetProvider.GetAllSweets();
            Sweet[] result = null;
            foreach (var sweet in sweets)
            {
                ArrayHelper.AddElementToArray(ref result, sweet.GetChocolateGlazedCandy(glazeType, chocolateType));
            }

            return result;
        }

        public Sweet[] GetWithFillerChocolateGlazedCandy(GlazeType glazeType, ChocolateType chocolateType, string filler)
        {
            var sweets = _sweetProvider.GetAllSweets();
            Sweet[] result = null;
            foreach (var sweet in sweets)
            {
                ArrayHelper.AddElementToArray(ref result, sweet.GetWithFillerChocolateGlazedCandy(glazeType, chocolateType, filler));
            }

            return result;
        }

        public Sweet[] GetWithNutsChocolateGlazedCandy(GlazeType glazeType, ChocolateType chocolateType, string nut)
        {
            var sweets = _sweetProvider.GetAllSweets();
            Sweet[] result = null;
            foreach (var sweet in sweets)
            {
                ArrayHelper.AddElementToArray(ref result, sweet.GetWithNutsChocolateGlazedCandy(glazeType, chocolateType, nut));
            }

            return result;
        }

        public Sweet[] GetSweetByPrice(double minPrice, double maxPrice)
        {
            var sweets = _sweetProvider.GetAllSweets();
            Sweet[] result = null;
            foreach (var sweet in sweets)
            {
                ArrayHelper.AddElementToArray(ref result, sweet.GetSweetByPrice(minPrice, maxPrice));
            }

            return result;
        }

        public void SortAllSweetByName()
        {
            Array.Sort(_sweetProvider.GetAllSweets(), new SweetComparer());
        }

        public void SortAllChocolateByType()
        {
            Array.Sort(_sweetProvider.GetAllSweets(), new ChocolateComparer());
        }

        public Sweet[] GetAllSweets()
        {
            return _sweetProvider.GetAllSweets();
        }

        public Sweet[] GetRandomSweets()
        {
            var allSweets = GetAllSweets();
            var sweetToOutCount = _random.Next(1, allSweets.Length - 1);
            Sweet[] sweetToOut = null;
            foreach (var item in allSweets)
            {
                ArrayHelper.AddElementToArray(ref sweetToOut, allSweets[_random.Next(0, sweetToOutCount + 1)]);
            }

            return sweetToOut;
        }
    }
}
