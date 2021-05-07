using Mirror;
using UnityEngine;

public class GamePlayer : NetworkBehaviour
{

    [SyncVar]
    public Races race;

    [SyncVar]
    public Faction faction;

    [SyncVar]
    public Class playerClass;

    [SyncVar]
    public string playerName;

    [SyncVar]
    public int speed;



    public void Start()
    {
    }
}
