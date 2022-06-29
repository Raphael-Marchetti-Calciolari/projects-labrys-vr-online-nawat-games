using System;
using UnityEngine;
public class PlayerStatus : MonoBehaviour
{
    public static Action<GameObject> NotifyPlayerDead;

    [SerializeField] private float life;
    [SerializeField] private float maxLife;
    [SerializeField] private float speed;
    [SerializeField] private bool alive;
    [SerializeField] private float weight;
    [SerializeField] private float stamina;
    [SerializeField] private bool isEffectActive;


    private void Start()
    {
        
    }

    public void Logout()
    {
        // Logout from session
    }

    public void ChangeSpeed(float newSpeed){
        this.speed += newSpeed;
        this.isEffectActive = true;
        // delay
        // this.speed -= newSpeed;
        // this.isEffectActive = false;
    }
    public void ChangeLife(float healPoints){
        this.life += healPoints;
        if (this.life <= 0){
            alive = false;
            NotifyPlayerDead?.Invoke(gameObject);
        }
        else if (this.life > this.maxLife){
            this.life = this.maxLife;
        }
    }
    public void Walk(float walkSpeed){}
}
