
using UnityEngine;

public class ItemStack
{
    [SerializeField] private ItemType itemType;
    public ItemType ItemType => itemType;
    [SerializeField] private int count;
    public int Count => count;
}
