
using DungeonRunner.Enemy;
using DungeonRunner.Loot;
using DungeonRunner.Traps;

namespace DungeonRunner.Dungeon.Rooms;

public abstract class BaseRoom
{
    public ITrap[]? traps;
    public ILoot[]? loots;
    public IEnemy[]? enemies;
}
