namespace Assignment_5
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"SMS Sending to {recipient}: {message}");
        }
    }
}
