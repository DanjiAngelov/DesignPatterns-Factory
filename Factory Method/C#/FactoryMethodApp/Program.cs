using FactoryMethodApp.Notifications;

class Program
{
    static void Main(string[] args)
    {
        NotificationCreator creator = new EmailNotificationCreator();
        creator.SendNotification("Hello from Factory Method!");
    }
}