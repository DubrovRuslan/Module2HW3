namespace Module2HW3.Models
{
    public class WithFillerChocolate : Chocolate
    {
        public string TasteOfFiller { get; set; }
        public override WithFillerChocolate Clone()
        {
            return new WithFillerChocolate
            {
                Name = Name,
                Price = Price,
                Weight = Weight,
                TypeChocolate = TypeChocolate,
                TasteOfFiller = TasteOfFiller
            };
        }
    }
}
