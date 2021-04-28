using TMPro;
using UnityEngine;

public class GamePlayer
{
    //Variables for the server to sync to the client
    //TODO: Look into sending a message back opposed to syncing these to all clients
    [HideInInspector]
    public Races race;

    [HideInInspector]
    public Faction faction;

    [HideInInspector]
    public Class playerClass;

    [HideInInspector]
    public string playerName;

    [HideInInspector]
    public int speed;


    //TODO: Possibly move this out of this script as this script is intended for player information
    private TMP_Text playerNameText;

    public void Start()
    {
        //playerNameText = GetComponentInChildren<TMP_Text>();
        if (playerNameText != null)
        {
            playerNameText.text = playerName;
        }
    }
}
