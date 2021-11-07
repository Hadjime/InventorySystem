using System;
using InventorySystem.Abstract;

namespace InventorySystem
{
    public class InventorySlot: IInventorySlot
    {
        public bool isFull => amount == capacity;
        public bool isEmpty => item == null;
        public IInventoryItem item { get; private set; }
        public Type itemType => item.type;
        public int amount => isEmpty? 0: item.amount;
        public int capacity { get; private set; }
        public void SetItem(IInventoryItem item)
        {
            if (!isEmpty) return;

            this.item = item;
            this.capacity = item.maxItemsInInventorySlot;
        }

        public void Clear()
        {
            if (!isEmpty) return;

            item.amount = 0;
            item = null;
        }
    }
}