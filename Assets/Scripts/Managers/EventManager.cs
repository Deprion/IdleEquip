using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void IsAvailableUpgradeDel();
    public event IsAvailableUpgradeDel IsAvailableUpgrade;
    public delegate void ExpGainDel(long amount);
    public event ExpGainDel ExpGain;
    private void Start()
    {

        ExpGain += AddExp();
    }
    private void AddExp(long amount)
    { 
        
    }
}
