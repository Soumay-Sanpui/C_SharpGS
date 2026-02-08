using GameStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStoreAPI.Data;

// DbContextOptions<GameStoreContext> --> this is just a label not the class object.
// [options] --> for --> [which ? DbContext]
// Whichever class inherits the DbContext they need to have the DbContextOptions<T> of the same type, like, here <T> == ClassName
public class GameStoreContext(DbContextOptions<GameStoreContext> options) : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();
    public DbSet<Genre> Genres => Set<Genre>();
}
