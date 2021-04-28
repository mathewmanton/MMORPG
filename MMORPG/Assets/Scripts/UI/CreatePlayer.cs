using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class CreatePlayer : MonoBehaviour
{
    public TMP_InputField playerName;
    public TMP_Dropdown faction;
    public TMP_Dropdown race;
    public TMP_Dropdown playerClasses;
    public Button createButton;
    public GameObject userInterface;


    private RaceDatabase raceDatabase;
    private ClassDatabase classdatabase;
    private List<Race> allianceList;
    private List<Race> hordeList;

    [SerializeField]
    private MMONetworkManager networkManager;

    void Start()
    {
        allianceList = networkManager.raceDatabase.GetAllianceRaces();
        hordeList = networkManager.raceDatabase.GetHordeRaces();

        PopulateRace(Faction.Alliance);
        PopulateClasses(Races.NightElf);

        //when switching factions. re-populate the races
        faction.onValueChanged.AddListener(delegate (int id) {
            PopulateRace((Faction)id);

            Races race = id == 0 ? Races.NightElf : Races.BloodElf;
            PopulateClasses(race);
        });

        //When changing races, re-populate the classes.
        race.onValueChanged.AddListener(delegate (int id) {
            Race currentRace = raceDatabase.GetRaceByName(race.options[id].text);
            PopulateClasses(currentRace.raceName);
        });

        createButton.onClick.AddListener(() => {
            Create();
        });
    }

    /// <summary>
    /// Populate the race dropdown using races allowed for the faction selected
    /// </summary>
    /// <param name="faction"></param>
    private void PopulateRace(Faction faction)
    {
        race.ClearOptions();
        List<Race> races = faction == Faction.Alliance ? allianceList : hordeList;
        List<string> raceNames = new List<string>();

        foreach(Race playerRace in races)
        {
            raceNames.Add(playerRace.raceName.ToString());
        }

        race.AddOptions(raceNames);
    }

    /// <summary>
    /// Populate the dropdown for classes that the player is allowed to choose from for that race
    /// </summary>
    /// <param name="race"></param>
    private void PopulateClasses(Races race)
    {
        playerClasses.ClearOptions();
        List<PlayerClass> classes = classdatabase.RetrieveAllowedClassesForRace(race);
        List<string> classNames = new List<string>();
        
        foreach(PlayerClass playerClass in classes)
        {
            classNames.Add(playerClass.className.ToString());
        }

        playerClasses.AddOptions(classNames);
    }

    /// <summary>
    /// Create a new character to spawn into the game
    /// </summary>
    private void Create()
    {
        //Send message to server to create a new character and spawn them into the game
        CreateMMOCharacterMessage characterMessage = new CreateMMOCharacterMessage
        {
            race = raceDatabase.GetRaceByName(race.captionText.text).raceName,
            playerName = playerName.text,
            faction = (Faction)faction.value,
            playerClass = classdatabase.GetClassByName(playerClasses.captionText.text).className,
            speed = 10
        };

        gameObject.SetActive(false);

        //TODO: When separating out the character creation, this will need to be removed
        userInterface.SetActive(true);
        
    }
}
