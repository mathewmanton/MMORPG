using System.Collections.Generic;


public class ClassDatabase
{
    private readonly List<PlayerClass> playerClasses;

    public ClassDatabase()
    {
        playerClasses = new List<PlayerClass>();
        CreateClasses();
    }

    /// <summary>
    /// Retrieve classes that are allowed for the race
    /// </summary>
    /// <param name="race"></param>
    /// <returns>a list of player classes</returns>
    public List<PlayerClass> RetrieveAllowedClassesForRace(Races race)
    {
        return playerClasses.FindAll(pc => pc.IsRaceAllowed(race));
    }

    /// <summary>
    /// Get a single class by it's name
    /// </summary>
    /// <param name="name"></param>
    /// <returns>a player class</returns>
    public PlayerClass GetClassByName(string name)
    {
        foreach (PlayerClass playerClass in playerClasses)
        {
            if (string.Compare(name, playerClass.className.ToString()) == 0)
            {
                return playerClass;
            }
        }

        return null;
    }

    private void CreateClasses()
    {
        playerClasses.Add(new PlayerClass(Class.Druid, new List<Races>() { Races.NightElf, Races.Troll }));
        playerClasses.Add(new PlayerClass(Class.Mage, new List<Races>() { Races.Human, Races.Gnome, Races.Undead, Races.Troll, Races.Orc, Races.BloodElf }));
        playerClasses.Add(new PlayerClass(Class.Shaman, new List<Races>() { Races.Orc, Races.Troll }));
        playerClasses.Add(new PlayerClass(Class.Warlock, new List<Races>() { Races.Human, Races.Gnome, Races.BloodElf, Races.Undead }));
        playerClasses.Add(new PlayerClass(Class.Warrior, new List<Races>() { Races.NightElf, Races.Troll, Races.BloodElf, Races.Dwarf, Races.Gnome, Races.Human, Races.Orc, Races.Undead }));
    }

}
