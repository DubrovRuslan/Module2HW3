namespace Module2HW3.Models
{
    public class WithNutsGlazedCandy : GlazedCandy
    {
        public string[] Nuts { get; set; }

        public override WithNutsGlazedCandy Clone()
        {
            return new WithNutsGlazedCandy
            {
                Name = Name,
                Price = Price,
                Weight = Weight,
                Nuts = Nuts,
                TypeGlaze = TypeGlaze
            };
        }
    }
}
