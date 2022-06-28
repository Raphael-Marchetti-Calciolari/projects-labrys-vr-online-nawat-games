using System;
using System.Collections;
using UnityEngine;

public class Consumable : MonoBehaviour
{
    public static string consumableClassTag = "Consumable";
    public static event Action<float, GameObject> NotifyPlayerCollision;

    [SerializeField] private float bonusValue { get; set; }
    [SerializeField] private bool collectedStatus { get; set; }
    [SerializeField] private bool isSabotage { get; set; }

    private void Start()
    {
        isSabotage = false;
        collectedStatus = false;
        Sword.NotifySabotage += Sabotage;
        if (!gameObject.tag.Equals(consumableClassTag)) Debug.Log($"Consumable instance \"{gameObject.name}\" has no tag or wrong tag attributed!");
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
    }
}
