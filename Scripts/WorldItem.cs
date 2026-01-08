using UnityEngine;

public class WorldItem : MonoBehaviour
{
    public ItemData itemData; // Bu nesne hangi eþyayý temsil ediyor?

    public ItemData PickUp()
    {
        Destroy(gameObject);
        return itemData;
    }
}