using GameStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStoreAPI.Data;

public static class DataExtensions
{
    public static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
        dbContext.Database.Migrate();
    }

    public static void AddGameStoreDb(this WebApplicationBuilder builder)
    {
        // injecting context options for db. (DI)
        const string connString = "Data Source=GameStore.db";
        builder.Services.AddSqlite<GameStoreContext>(connString,
            optionsAction: options => options.UseSeeding((context, _) =>
            {
                if (context.Set<Genre>().Any()) return;
                context.Set<Genre>().AddRange(
                    new Genre {Name = "Fighting"},
                    new Genre {Name = "RPG"},
                    new Genre {Name = "Racing"},
                    new Genre {Name = "Sports"}
                );
            
                context.SaveChanges();
            })
        );
    }
}
