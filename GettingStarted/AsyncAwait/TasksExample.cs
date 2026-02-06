namespace GettingStarted.AsyncAwait;

/// <summary>
/// Clear, small examples demonstrating the difference between
/// sequential awaiting and concurrent tasks using <c>async</c>/<c>await</c>.
/// </summary>
public static class TaskExample
{
    /// <summary>
    /// Entry point used by the sample <see cref="Program"/>.
    /// This method blocks the caller until the async demo completes so it can
    /// be called from a non-async <c>Main</c>.
    /// </summary>
    public static void StartExample()
    {
        RunAsync().GetAwaiter().GetResult();
    }

    private static async Task RunAsync()
    {
        Console.WriteLine("=== Async/Await demo ===");

        // Start two independent tasks concurrently
        var washTask = WashClothesAsync();
        var cookTask = CookFoodAsync();

        Console.WriteLine("Both tasks started — waiting for both with Task.WhenAll...");
        var results = await Task.WhenAll(washTask, cookTask);
        foreach (var r in results)
            Console.WriteLine(r);

        // Sequential awaiting: start, wait, then start next
        Console.WriteLine("Now running sequentially (start then await each)...");
        var r1 = await WashClothesAsync();
        Console.WriteLine(r1);
        var r2 = await CookFoodAsync();
        Console.WriteLine(r2);

        Console.WriteLine("Demo finished.");
    }

    /// <summary>
    /// Simulates washing clothes asynchronously using a non-blocking delay.
    /// </summary>
    /// <returns>A task that completes with a message when washing is done.</returns>
    public static async Task<string> WashClothesAsync()
    {
        await Task.Delay(1000); // simulate I/O work without blocking a thread
        return "Done washing clothes.";
    }

    /// <summary>
    /// Simulates cooking food asynchronously using a non-blocking delay.
    /// </summary>
    /// <returns>A task that completes with a message when cooking is done.</returns>
    public static async Task<string> CookFoodAsync()
    {
        await Task.Delay(1500); // longer to illustrate concurrency
        return "Done cooking food.";
    }
}
