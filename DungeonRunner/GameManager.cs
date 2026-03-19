using DungeonRunner.Dungeon;

namespace DungeonRunner;

public sealed class GameManager
{
    // --Singleton Desing---------------------------------------------------
    private GameManager() {}
    private static readonly GameManager gameManager = new();
    // ---------------------------------------------------------------------
    
    public int Score {get; private set;} = 0;
    public readonly IDungeon? currentDungeon;
}
