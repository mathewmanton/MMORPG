using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            foreach(NetworkConnectionToClient connections in NetworkServer.connections.Values)
            {
                Debug.Log("Player - " + connections.connectionId + " " + connections.identity.gameObject.GetComponent<Inventory>().RemainingSlots());
            }
        }
        if(Input.GetKeyDown(KeyCode.M))
        {
            foreach (NetworkConnectionToClient connections in NetworkServer.connections.Values)
            {
                connections.identity.gameObject.GetComponent<Inventory>().CmdAddItem(new Item(0, "test", "test", ItemType.Armor, 5, 100), 2);
                return;
            }
        }
    }
}
