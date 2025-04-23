namespace EventEase.Services
{
    public class UserSessionService
    {
        public string? CurrentUserName { get; set; }
        public bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUserName);
    }
}