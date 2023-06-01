namespace Module2HW3.Models
{
    public class ChocolateGlazedCandy : GlazedCandy
    {
        public ChocolateType TypeChocolate { get; set; }

        public override ChocolateGlazedCandy Clone()
        {
            return new ChocolateGlazedCandy
            {
                Name = Name,
                Price = Price,
                Weight = Weight,
                TypeChocolate = TypeChocolate,
                TypeGlaze = TypeGlaze
            };
        }
    }
}
