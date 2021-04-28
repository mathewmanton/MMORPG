using System.Collections.Generic;

public enum Class { Druid, Mage, Warlock, Warrior, Shaman }

public class PlayerClass
{
    public Class className { get; }

    //TODO: Remove this and make the races class own which classes it's allowed to have
    private List<Races> racesAllowed;

    public PlayerClass(Class className, List<Races> racesAllowed)
    {
        this.className = className;
        this.racesAllowed = racesAllowed;
    }

    /// <summary>
    /// Check to see if the class is allowed to be selected by that race
    /// </summary>
    /// <param name="race"></param>
    /// <returns></returns>
    public bool IsRaceAllowed (Races race)
    {
        return racesAllowed.Contains(race);
    }
}
