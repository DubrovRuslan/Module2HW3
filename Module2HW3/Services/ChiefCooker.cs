using Module2HW3.Models;

namespace Module2HW3.Services
{
    public class ChiefCooker
    {
        private static readonly ChiefCooker _instance = new ChiefCooker();
        private PresentService _presentService = new PresentService();
        private SweetService _sweetService = new SweetService();
        private NotificationService _notificationService = new NotificationService();
        static ChiefCooker()
        {
        }

        private ChiefCooker()
        {
        }

        public static ChiefCooker Instance => _instance;

        public void PresentOfDarkChocolatesCandyWithoutGlaze()
        {
            var number = _presentService.AddNewPresent(_sweetService.GetChocolateGlazedCandy(GlazeType.None, ChocolateType.Dark));
            _notificationService.Notify(_presentService.GetAllPresents()[number]);
        }

        public void PresentByPrice(double minPrice, double maxPrice)
        {
            var number = _presentService.AddNewPresent(_sweetService.GetSweetByPrice(minPrice, maxPrice));
            _notificationService.Notify(_presentService.GetAllPresents()[number]);
        }

        public void AddRandomToPresent()
        {
            _sweetService.SortAllSweetByName();
            var number = _presentService.AddNewPresent(_sweetService.GetRandomSweets());
            _notificationService.Notify(_presentService.GetAllPresents()[number]);
        }
    }
}
