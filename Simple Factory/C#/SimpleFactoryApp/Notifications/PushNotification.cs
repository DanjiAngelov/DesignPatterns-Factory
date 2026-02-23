using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace SimpleFactoryApp.Notifications
{
    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending PUSH: {message}");
        }
    }
}
