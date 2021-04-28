using System.Collections.Generic;

public class Inventory
{
    public int maxSize;
    public int remainingSlots;
    public List<InventorySlot> slots;

    public Inventory(int size)
    {
        maxSize = size;
        slots = new List<InventorySlot>();
        SetupInventory();
        remainingSlots = RemainingSlots();
    }

    /// <summary>
    /// Add an item to the inventory or increase quantity of an existing item
    /// </summary>
    /// <param name="item"></param>
    /// <param name="amount"></param>
    public int AddItem(Item item, int amount)
    {
        int newAmount = amount;

        //Find an empty slot to insert item or an exisiting slot that has the same item already to increase it's quantity.
        foreach(InventorySlot slot in slots)
        {
            if (slot.item.id != item.id)
            {
                slot.item = item;
                newAmount = slot.AddAmount(newAmount);
            }
            else
            {
                newAmount = slot.AddAmount(newAmount);
            }

            //if the amount runs, break. No quantity of the item is left to put into the inventory.
            if(newAmount == 0)
            {
                break;
            }
        }

        return newAmount;
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

    /// <summary>
    /// Count how many slots are empty
    /// </summary>
    /// <returns>Remaining slots available</returns>
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

    private void SetupInventory()
    {
        for(int i = 0; i < maxSize; i++)
        {
            slots.Add(new InventorySlot(i, null, 0));
        }
    }
}
