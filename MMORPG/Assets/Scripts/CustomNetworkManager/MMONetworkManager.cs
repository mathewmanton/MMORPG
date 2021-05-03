using Mirror;
using System.Collections.Generic;

public class MMONetworkManager : NetworkManager
{
    public AccountDatabase accountDatabase;
    public ClassDatabase classDatabase;
    public ItemDatabase itemDatabase;
    public RaceDatabase raceDatabase;
    private readonly List<ItemObject> items;

    public override void OnClientDisconnect(NetworkConnection conn)
    {
        base.OnClientDisconnect(conn);

        //Save player data
        //This will be on game quit.
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);

        //This will be at the character select screen - load in last character played
        //Load character - Just name, level, race, equipment (for the model), class and model customization selections.
        //Everthing else can be loaded after the player selects the character to go in game.

        
    }

    public static void LoadPlayerData()
    {

    }

    public static void SavePlayerData()
    {

    }



}


