namespace Module2HW3.Models
{
    public class WithNutsChocolate : Chocolate
    {
        public string[] Nuts { get; set; }
        public override WithNutsChocolate Clone()
        {
            return new WithNutsChocolate
            {
                Name = Name,
                Price = Price,
                Weight = Weight,
                TypeChocolate = TypeChocolate,
                Nuts = Nuts
            };
        }
    }
}
