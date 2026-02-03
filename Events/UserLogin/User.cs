namespace C_SharpGS.Events.UserLogin
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void RunUserLoginExample()
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
