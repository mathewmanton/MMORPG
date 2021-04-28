
using System.Collections.Generic;
using System.Collections;

public class RaceDatabase
{
    //For now will be hardcoded - potentially add connections to a real DB in the future

    private List<Race> races;

    public RaceDatabase()
    {
        races = new List<Race>();
        CreateRaces();
    }

    //populate the races list
    private void CreateRaces()
    {
        races.Add(new Race(Races.NightElf, Faction.Alliance));
        races.Add(new Race(Races.Human, Faction.Alliance));
        races.Add(new Race(Races.Gnome, Faction.Alliance));
        races.Add(new Race(Races.Dwarf, Faction.Alliance));
        races.Add(new Race(Races.BloodElf, Faction.Horde));
        races.Add(new Race(Races.Orc, Faction.Horde));
        races.Add(new Race(Races.Troll, Faction.Horde));
        races.Add(new Race(Races.Undead, Faction.Horde));
    }

    public List<Race> GetAllianceRaces()
    {
        return races.FindAll(race => race.faction == Faction.Alliance);
    }

    public List<Race> GetHordeRaces()
    {
        return races.FindAll(race => race.faction == Faction.Horde);
    }

    public Race GetRaceByName(string name)
    {
        foreach (Race race in races)
        {
            if (string.Compare(name, race.raceName.ToString()) == 0)
            {
                return race;
            }
        }

        return null;
    }
}
