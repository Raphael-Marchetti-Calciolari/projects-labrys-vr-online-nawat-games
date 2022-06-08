using System;
using UnityEngine;

public class Consumable : MonoBehaviour
{
    public static event Action<float, GameObject> NotifyPlayerCollision;

    [SerializeField] private float bonusValue { get; set; }
    [SerializeField] private bool collectedStatus { get; set; }
    [SerializeField] private bool isSabotage { get; set; }

    private void Start()
    {
        isSabotage = false;
        collectedStatus = false;
    }

    private void Sabotage()
    {
        if (isSabotage) return;
        
        isSabotage = !isSabotage;
        bonusValue = -bonusValue;
        
        // Coroutine timer
    }

    private void ChangeActivatedStatus()
    {
        collectedStatus = !collectedStatus;
        if (collectedStatus)
        {
            // Activate consumable procedure
        }
        else
        {
            // Deactivate consumable procedure
        }
        
        // Can have a timer to reappear
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(Player.playerClassTag))
        {
            NotifyPlayerCollision?.Invoke(bonusValue, collision.gameObject);
            ChangeActivatedStatus();
        }
        else if (collision.gameObject.tag.Equals(Sword.swordClassTag))
            Sabotage();
    }
}
