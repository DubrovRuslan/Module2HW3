using Module2HW3.Services;

namespace Module2HW3
{
    public class Starter
    {
        private ChiefCooker _chief;
        public Starter()
        {
            _chief = ChiefCooker.Instance;
        }

        public void Run()
        {
            _chief.PresentOfDarkChocolatesCandyWithoutGlaze();
            _chief.AddRandomToPresent();
            _chief.PresentByPrice(10, 30);
        }
    }
}
