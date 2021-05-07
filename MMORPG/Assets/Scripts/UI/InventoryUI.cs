using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    public TextMeshProUGUI text;

    private GameObject player;
    private PlayerInventory playerInventory;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player(Clone)");

        //Should never happen
        if(player == null)
        {
            Debug.Log("Could not find player..... very bad!");
            return;
        }

        playerInventory = player.GetComponent<PlayerInventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInventory != null)
        {
            text.text = playerInventory.inventory.RemainingSlots().ToString();
        }
    }
}
