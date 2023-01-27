using System;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] private ItemListConfig itemList;
    [SerializeField] private ItemSlot[] itemSlots;

    private void OnEnable()
    {
        for (var i = 0; i < itemSlots.Length; i++)
        {
            itemSlots[i].ItemReceived += ISlotOnItemReceived;
            itemSlots[i].ItemLost += ISlotOnItemLost;
            
            itemSlots[i].SetSlotId(i);
        }
    }

    private void OnDisable()
    {
        for (var i = 0; i < itemSlots.Length; i++)
        {
            itemSlots[i].ItemReceived -= ISlotOnItemReceived;
        }
    }

    private void ISlotOnItemReceived(ItemType obj, int slotId)
    {
        throw new NotImplementedException();
    }
    
    private void ISlotOnItemLost(ItemType obj, int slotId)
    {
        throw new NotImplementedException();
    }
}
