using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodApp.Notifications
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();

        public void SendNotification(string message)
        {
            var notification = CreateNotification();
            notification.Send(message);
        }
    }
}