using System;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    public event Action<ItemType, int> ItemReceived;
    public event Action<ItemType, int> ItemLost;
    
    [SerializeField] private RectTransform itemIconPosition;
    [SerializeField] private ItemIcon heldItem;

    private int _id;

    public void SetSlotId(int id)
    {
        _id = id;
    } 
    
    private void OnItemReceived(ItemIcon iIcon)
    {
        ItemReceived?.Invoke(iIcon.ItemStack.ItemType, _id);
    }
    private void OnItemLost(ItemIcon iIcon)
    {
        ItemLost?.Invoke(iIcon.ItemStack.ItemType, _id);
    }
}