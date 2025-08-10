namespace Assignment_5
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Email Sending to {recipient}: {message}");
        }
    }
}
