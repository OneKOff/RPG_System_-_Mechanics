using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "RPG_Systems/Inventory/ItemType")]
public class ItemType : ScriptableObject
{
    [SerializeField] private int id;
    public int Id => id;
    [SerializeField] private string itemName;
    public string ItemName => itemName;
    [SerializeField] private Sprite itemSprite;
    public Sprite ItemSprite => itemSprite;
}
