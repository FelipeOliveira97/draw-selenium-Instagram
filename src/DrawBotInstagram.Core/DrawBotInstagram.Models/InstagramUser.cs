namespace DrawBotInstagram.Models
{
    public class InstagramUser
    {
        public readonly string UserName;

        public InstagramUser(string userName)
        {
            UserName = userName.Contains("@") ? userName : $"@{userName}";
        }
    }
}