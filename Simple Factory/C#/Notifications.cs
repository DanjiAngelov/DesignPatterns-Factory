using SimpleFactoryApp.Notifications;

class Program
{
    static void Main(string[] args)
    {
        var notification = NotificationFactory.CreateNotification("email");
        notification.Send("Hello from Simple Factory!");
    }
}