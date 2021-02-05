using UnityEngine;

public class UArray : MonoBehaviour
{
    public int PriceMoney;
    public int PriceShards;
    public Item[] itemArray;
    public UArray(int money, int shards, params Item[] array)
    {
        PriceMoney = money;
        PriceShards = shards;
        if (array.Length != 0)
        {
            itemArray = new Item[array.Length];
            array.CopyTo(itemArray, 0);
        }
    }
    public void DoUpgrade(ref int money, ref int shards)
    {
        money -= PriceMoney;
        shards -= PriceShards;
    }
    public void DoUpgrade(ref int money, ref int shards, params Item[] array)
    {
        money -= PriceMoney;
        shards -= PriceShards;
        Inventory.Instance.DeleteItem(array);
    }
}
