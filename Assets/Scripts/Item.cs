using UnityEngine;

public class Item : MonoBehaviour
{
    public string NameObject { get; }
    public StaticManager.Type Type { get; }
    public int MinLvl { get; }
    public int BasePriceUpgrade { get; }
    public int CurrentPriceUpgrade { get; set; }
    public int MaxUpgrade { get; set; }
    public int CurrentUpgrade { get; set; }
    public int MaxStars { get; }
    public int CurrentStars { get; set; }
    public StaticManager.Rare Rare { get; }
    public float MinValue { get; }
    public float MaxValue { get; }
    public bool IsExtraValue { get; set; }
    public float MinValueExtra { get; set; }
    public float MaxValueExtra { get; set; }
    public Item(ItemSO so)
    {
        NameObject = so.NameObject;
        Type = so.Type;
        MinLvl = so.MinLvl;
        BasePriceUpgrade = so.BasePriceUpgrade;
        CurrentPriceUpgrade = so.BasePriceUpgrade;
        MaxUpgrade = so.MaxUpgrade;
        CurrentUpgrade = 0;
        MaxStars = so.MaxStars;
        CurrentStars = so.CurrentStars;
        Rare = so.Rare;
        MinValue = so.MinValue;
        MaxValue = so.MaxValue;
        IsExtraValue = so.IsExtraValue;
        MinValueExtra = so.MinValueExtra;
        MaxValueExtra = so.MaxValueExtra;
    }
    public Item(Item item)
    {
        NameObject = item.NameObject;
        Type = item.Type;
        MinLvl = item.MinLvl;
        BasePriceUpgrade = item.BasePriceUpgrade;
        CurrentPriceUpgrade = item.CurrentPriceUpgrade;
        MaxUpgrade = item.MaxUpgrade;
        CurrentUpgrade = item.CurrentUpgrade;
        MaxStars = item.MaxStars;
        CurrentStars = item.CurrentStars;
        Rare = item.Rare;
        MinValue = item.MinValue;
        MaxValue = item.MaxValue;
        IsExtraValue = item.IsExtraValue;
        MinValueExtra = item.MinValueExtra;
        MaxValueExtra = item.MaxValueExtra;
    }
    public void Upgrade()
    {
        if (MaxUpgrade != CurrentUpgrade)
        {

        }
        else
        { 
            
        }
    }
    public bool IsUpgrade()
    {
        return true;
    }
}
