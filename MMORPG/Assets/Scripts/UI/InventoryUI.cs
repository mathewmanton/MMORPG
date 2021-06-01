using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    public TextMeshProUGUI text;

    private GameObject player;
    private PlayerInventory playerInventory;


    // Update is called once per frame
    void Update()
    {
        if (playerInventory != null)
        {
            text.text = playerInventory.inventory.RemainingSlots().ToString();
        }
    }
}
