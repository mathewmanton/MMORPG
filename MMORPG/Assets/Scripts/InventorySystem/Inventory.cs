using Mirror;

public class Inventory : NetworkBehaviour
{
    public int width;
    public int height;

    private SyncList<InventorySlot> slots = new SyncList<InventorySlot>();
    private int maxSize;

    private void Awake()
    {
        maxSize = width * height;
    }

    [Command]
    public void CmdAddItem(Item item, int amount)
    {
        int newAmount = amount;

        foreach(InventorySlot slot in slots)
        {
            if(slot.item != null && slot.item.id == item.id)
            {
                newAmount = slot.AddAmount(newAmount);

                if(newAmount == 0)
                {
                    return;
                }
            }
        }

        //if any is left then find a spot where there is no item and add the rest there
        foreach(InventorySlot slot in slots)
        {
            if(slot.item == null)
            {
                slot.item = item;
                newAmount = slot.AddAmount(newAmount);
            }

            if(newAmount == 0)
            {
                return;
            }
        }

        //There is some left over and backpack is full
        //do something here.
    }


    public void RemoveItem()
    {

    }

    public void SplitItem()
    {
    }

    public void SwapItem()
    {

    }

    public int RemainingSlots()
    {
        int remainingSlots = 0;

        foreach(InventorySlot slot in slots)
        {
            if(slot.item == null)
            {
                remainingSlots++;
            }
        }

        return remainingSlots;
    }

    [Command]
    public void SetupInventory()
    {
        for(int i = 0; i < maxSize; i++)
        {
            slots.Add(new InventorySlot(i, null, 0));
        }
    }
}
