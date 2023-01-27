using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemListConfig", menuName = "RPG_Systems/Inventory/ItemListConfig")]
public class ItemListConfig : ScriptableObject
{
    [SerializeField] private List<ItemType> items = new List<ItemType>();

    public ItemType GetItemById(int id)
    {
        return items.Find(c => c.Id == id);
    }
}