using System;

namespace InventorySystem.Abstract
{
    public interface IInventoryItem
    {
        bool isEquiped { get; set; }
        Type type { get; }
        int maxItemsInInventorySlot { get; }
        int amount { get; set; }

        IInventoryItem Clone();
    }
}
