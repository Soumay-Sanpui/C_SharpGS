namespace GettingStarted.Events.UserLogin
{
    public class BlockUserEventArgs(User user) : EventArgs
    {
        public User user = user;
    }

    public class UserService(User user)
    {
        private const string CUserPass = "password";
        private int _maxRetries = 3;
        
        public event EventHandler<BlockUserEventArgs>? BlockUser;

        private bool IsLoginRetryAvailable()
        {
            return !_maxRetries.Equals(0);
        }
        
        /**
         * UserLogin() - Login a user using password
         */
        public void UserLogin()
        {
            if (IsLoginRetryAvailable())
            {
                if (user.Password is CUserPass)
                {
                    Console.WriteLine($"User {user.Username} successfully logged in.");
                }
                else
                {
                    Console.WriteLine($"User {user.Username} failed to login.");
                    _maxRetries--;
                }
            }
            else
            {
                Console.WriteLine($"User {user.Username}, Your max login retry limit exceeded.");
            }
        }

        protected void OnBlockUser(User userToBlock)
        {
            BlockUser?.Invoke(this, new BlockUserEventArgs(userToBlock));
        }
    }
}