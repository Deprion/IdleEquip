using UnityEngine;

[CreateAssetMenu(menuName = "ItemSO", fileName = "ItemSO")]
public class ItemSO : ScriptableObject
{
    public string NameObject { get; }
    public StaticManager.Type Type { get; }
    public int MinLvl { get; }
    public int BasePriceUpgrade { get; }
    public int MaxUpgrade { get; }
    public int MaxStars { get; }
    public int CurrentStars { get; }
    public StaticManager.Rare Rare { get; }
    public float MinValue { get; }
    public float MaxValue { get; }
    public bool IsExtraValue { get; }
    public float MinValueExtra { get; }
    public float MaxValueExtra { get; }
}
