namespace C_SharpGS.Events.UserLogin
{
    public class EmailService
    {
        public static void BlockUserEmail(Object? sender, BlockUserEventArgs e)
        {
            Console.WriteLine($"{e.user.Username}, you have been blocked by the system.");
        }
    }
}
