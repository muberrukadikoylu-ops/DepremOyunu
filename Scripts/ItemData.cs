
using UnityEngine;

[CreateAssetMenu(fileName = "Yeni Esya", menuName = "Inventory/Item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public GameObject itemPrefab; // Yere býrakýldýðýnda oluþacak nesne
}