namespace GettingStarted.Events.UserLogin
{
    public class User
    {
        public string? Username { get; private init; }
        public string? Password { get; private init; }

        public static void RunUserLoginExample()
        {
            User puja = new()
            {
                Username = "Puja",
                Password = "Puja",
            };
            UserService userService = new(puja);
            userService.BlockUser += EmailService.BlockUserEmail;
            
            userService.UserLogin();
            userService.UserLogin();
            userService.UserLogin();
            userService.UserLogin();
        }
    }
}