namespace Module2HW3.Models
{
    public class WithFillerChocolateGlazedCandy : ChocolateGlazedCandy
    {
        public string Filler { get; set; }
        public override WithFillerChocolateGlazedCandy Clone()
        {
            return new WithFillerChocolateGlazedCandy
            {
                Name = Name,
                Price = Price,
                Weight = Weight,
                TypeChocolate = TypeChocolate,
                Filler = Filler,
                TypeGlaze = TypeGlaze
            };
        }
    }
}
