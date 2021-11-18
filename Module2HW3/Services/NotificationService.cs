using System.Text;
using Module2HW3.Models;

namespace Module2HW3.Services
{
    public class NotificationService
    {
        private readonly ConsoleNotificator _consoleNotificator;

        public NotificationService()
        {
            _consoleNotificator = new ConsoleNotificator();
        }

        public void Notify(Present present)
        {
            var message = new StringBuilder();
            message.AppendLine($"Сформирован подарок весом {present.TotalWeight}");
            message.AppendLine("В составе:");

            foreach (var item in present.Sweets)
            {
                message.AppendLine(item.Name);
            }

            _consoleNotificator.WriteToConsole(message.ToString());
        }
    }
}
