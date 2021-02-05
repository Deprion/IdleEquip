using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void IsAvailableUpgradeDel();
    public event IsAvailableUpgradeDel IsAvailableUpgrade;
}
