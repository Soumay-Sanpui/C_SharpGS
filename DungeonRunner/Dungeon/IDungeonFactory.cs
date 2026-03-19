using DungeonRunner.Enemy;
using DungeonRunner.Loot;
using DungeonRunner.Traps;

namespace DungeonRunner.Dungeon;

public interface IDungeonFactory
{
    public ILoot CreateDungeonLoot();
    public IEnemy CreateDungeonEnemy();
    public ITrap CreateDungeonTrap();
}
