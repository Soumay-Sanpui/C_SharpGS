using DungeonRunner.Loot;

namespace DungeonRunner.Hero;

public class Hero
{
    public Hero()
    {
        Console.WriteLine("Hero created...");
    }
    public ILoot? weapon;
    private ICombatStyle? _combatStyle;

    public void SetCombatStyle(ICombatStyle combatStyle) => _combatStyle = combatStyle;
}
