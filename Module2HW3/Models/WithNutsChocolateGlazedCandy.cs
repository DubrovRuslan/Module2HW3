namespace Module2HW3.Models
{
    public class WithNutsChocolateGlazedCandy : ChocolateGlazedCandy
    {
        public string[] Nuts { get; set; }
        public override WithNutsChocolateGlazedCandy Clone()
        {
            return new WithNutsChocolateGlazedCandy
            {
                Name = Name,
                Price = Price,
                Weight = Weight,
                TypeChocolate = TypeChocolate,
                Nuts = Nuts,
                TypeGlaze = TypeGlaze
            };
        }
    }
}
