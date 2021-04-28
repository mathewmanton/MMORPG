public enum Races { Human, NightElf, Dwarf, Gnome, Troll, BloodElf, Orc, Undead };
public enum Faction { Alliance, Horde };

public class Race 
{
    public Races raceName { get; set; }
    public Faction faction { get; set; }

    public Race(Races raceName, Faction faction)
    {
        this.raceName = raceName;
        this.faction = faction;
    }
}
