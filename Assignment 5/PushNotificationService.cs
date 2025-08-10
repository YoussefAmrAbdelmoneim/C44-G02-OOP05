namespace Assignment_5
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Push Sending to {recipient}: {message}");
        }
    }
}
