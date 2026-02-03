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
    }
}
