namespace Assignment_5
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private string storedUsername = "youssef";
        private string storedPassword = "1234";
        private string storedRole = "Administrator";
        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    }
}
