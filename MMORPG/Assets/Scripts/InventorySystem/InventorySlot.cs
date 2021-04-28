[System.Serializable]
public class InventorySlot
{
    public int slotId;
    public Item item;
    public int amount;

    public InventorySlot(int slotId, Item item, int amount)
    {
        this.slotId = slotId;
        this.item = item;
        this.amount = amount;
    }

    /// <summary>
    /// Add more quantity to the stack
    /// </summary>
    /// <param name="amount"></param>
    /// <returns>Any remainder of the item</returns>
    public int AddAmount(int amount)
    {
        int newAmount = 0;

        if (amount + this.amount <= item.maxQuantity)
        {
            this.amount += amount;
        }
        else
        {
            newAmount = amount;
            int difference = item.maxQuantity - this.amount;
            this.amount += difference;
            newAmount -= difference;
        }

        return newAmount;
    }
}

