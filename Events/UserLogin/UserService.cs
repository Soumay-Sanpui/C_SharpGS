namespace C_SharpGS.Events.UserLogin
{
    public class BlockUserEventArgs : EventArgs
    {
        public User user;
        public BlockUserEventArgs(User user)
        {
            this.user = user;
        }
    }

    public class UserService
    {
        private User _user;
        private const string c_userPass = "password";
        private int _maxRetries = 3;
        
        public event EventHandler<BlockUserEventArgs> BlockUser;

        public UserService(User user)
        {
            _user = user;
        }

        public bool IsLoginRetryAvailable()
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
                if (_user.Password.Equals(c_userPass))
                {
                    Console.WriteLine($"User {_user.Username} successfully logged in.");
                }
                else
                {
                    Console.WriteLine($"User {_user.Username} failed to login.");
                    _maxRetries--;
                }
            }
            else
            {
                Console.WriteLine($"User {_user.Username}, Your max login retry limit exceeded.");
            }
        }

        protected virtual void OnBlockUser(User user)
        {
            BlockUser?.Invoke(this, new BlockUserEventArgs(user));
        }
    }
}
