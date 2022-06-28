using System;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public static string trapClassTag = "Trap";
    public static event Action<float, GameObject> NotifyPlayerCollision;
    public event Action<bool> NotifyTrapActivatedStatusChange;
    
    [SerializeField] private bool activatedStatus;
    [SerializeField] private float timeActivated;
    [SerializeField] private float damage;
    [SerializeField] private Button[] activators;

    private void Start(){
        if (!gameObject.tag.Equals(trapClassTag)) Console.WriteLine($"Trap instance ${gameObject} has no tag or wrong tag attributed!");
    }

    private void OnEnable()
    {
        foreach (var button in activators)
        {
            button.NotifyButtonPressed += ChangeActivatedStatus;
        }
    }

    private void OnDisable()
    {
        foreach (var button in activators)
        {
            button.NotifyButtonPressed -= ChangeActivatedStatus;
        }
    }

    private void ChangeActivatedStatus()
    {
        activatedStatus = !activatedStatus;
        if (activatedStatus)
        {
            // Activate trap procedure
        }
        else
        {
            // Deactivate trap procedure
        }
        
        // Play trap animation
        NotifyTrapActivatedStatusChange?.Invoke(activatedStatus);
        
        // Coroutine timer
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(Player.playerClassTag))
            NotifyPlayerCollision?.Invoke(damage, collision.gameObject);
    }
}
