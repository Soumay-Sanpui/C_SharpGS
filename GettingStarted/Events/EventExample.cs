using GettingStarted.Events.ProductStock;
using GettingStarted.Events.UserLogin;

namespace GettingStarted.Events;

public class EventExample
{
    public static void RunEventExamples()
    {
            Console.WriteLine("===EVENTS===");
            
            User.RunUserLoginExample(); // Solution to user login event problem.
            Product.RunProductStockExample(); // Solution to Product Stock problem.
    }

}