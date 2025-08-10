namespace Assignment_5
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password);
        public bool AuthorizeUser(string username, string role);
    }
}
