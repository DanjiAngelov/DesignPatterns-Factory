using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodApp.Notifications
{
    public class SmsNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
}