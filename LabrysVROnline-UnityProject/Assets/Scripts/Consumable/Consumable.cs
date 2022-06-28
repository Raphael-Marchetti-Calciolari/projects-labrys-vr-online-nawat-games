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
    [SerializeField] public ConsumableType consumableType {get;set;}

    private void Start()
    {
        isSabotage = false;
        collectedStatus = false;
        if (!gameObject.tag.Equals(consumableClassTag)) Debug.Log($"Consumable instance \"{gameObject.name}\" has no tag or wrong tag attributed!");
    }

    public void Sabotage()
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
            PlayerStatus playerStatus = collision.gameObject.GetComponent<PlayerStatus>();
            switch (this.consumableType){
                case ConsumableType.ENERGY_CHARGE:
                    playerStatus.ChangeSpeed(bonusValue);
                    break;
                case ConsumableType.FIRE_CHARGE:
                    // F
                    break;
                case ConsumableType.LIFE_CHARGE:
                    playerStatus.ChangeLife(bonusValue);
                    break;
            }
        }
    }
}
