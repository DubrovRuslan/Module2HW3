using Module2HW3.Providers;
using Module2HW3.Models;

namespace Module2HW3.Services
{
    public class PresentService
    {
        private PresentProvider _presentProvider = new PresentProvider();
        public int AddNewPresent(Sweet[] sweets)
        {
            var present = new Present();
            present.TotalPrice = 0.0;
            present.Sweets = new Sweet[sweets.Length];
            for (var i = 0; i < sweets.Length; i++)
            {
                present.TotalPrice += sweets[i].Price;
                present.TotalWeight += sweets[i].Weight;
                present.Sweets[i] = (Sweet)sweets[i].Clone();
            }

            return _presentProvider.AddNewPresent(present);
        }

        public Present[] GetAllPresents()
        {
            return _presentProvider.GetPresents();
        }
    }
}
