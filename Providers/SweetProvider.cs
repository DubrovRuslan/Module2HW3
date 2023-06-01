using Module2HW3.Helpers;
using Module2HW3.Models;

namespace Module2HW3.Providers
{
    public class SweetProvider
    {
        private Sweet[] _sweets;
        public SweetProvider()
        {
            _sweets = new Sweet[]
            {
                new Chocolate { Name = "Аленка", Weight = 100.0, Price = 14.0, TypeChocolate = ChocolateType.Dark },
                new ChocolateGlazedCandy { Name = "Амур", Weight = 10.0, Price = 4, TypeChocolate = ChocolateType.Dark, TypeGlaze = GlazeType.None },
                new WithNutsChocolate { Name = "Millenium White", Weight = 120.0, Price = 50, TypeChocolate = ChocolateType.WhiteAerated, Nuts = new string[] { "лесной орех" } },
                new WithNutsChocolate { Name = "Millenium", Weight = 120.0, Price = 45, TypeChocolate = ChocolateType.DarkAerated, Nuts = new string[] { "арахис" } },
                new WithNutsChocolate { Name = "Millenium White", Weight = 120.0, Price = 35, TypeChocolate = ChocolateType.WhiteAerated, Nuts = new string[] { "лесной орех" } },
                new WithFillerGlazedCandy { Name = "Super candy", Weight = 14.0, Price = 9, TypeGlaze = GlazeType.Sugar, Filler = "Мед" },
                new WithNutsGlazedCandy { Name = "There could be your ad)", Weight = 17.0, Price = 13, TypeGlaze = GlazeType.WhiteChocolate, Nuts = new string[] { "осторожно какосы!" } }
            };
        }

        public void AddSweet(Sweet newSweet)
        {
            ArrayHelper.AddElementToArray(ref _sweets, newSweet);
        }

        public Sweet[] GetAllSweets()
        {
            return _sweets;
        }
    }
}
