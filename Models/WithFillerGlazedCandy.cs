namespace Module2HW3.Models
{
    public class WithFillerGlazedCandy : GlazedCandy
    {
        public string Filler { get; set; }

        public override WithFillerGlazedCandy Clone()
        {
            return new WithFillerGlazedCandy
            {
                Name = Name,
                Price = Price,
                Weight = Weight,
                TypeGlaze = TypeGlaze,
                Filler = Filler
            };
        }
    }
}
