using Module2HW3.Helpers;
using Module2HW3.Models;

namespace Module2HW3.Providers
{
    public class PresentProvider
    {
        private Present[] _presents;
        public int AddNewPresent(Present present)
        {
            ArrayHelper.AddElementToArray(ref _presents, present);
            return _presents.Length - 1;
        }

        public Present[] GetPresents()
        {
            return _presents;
        }
    }
}
