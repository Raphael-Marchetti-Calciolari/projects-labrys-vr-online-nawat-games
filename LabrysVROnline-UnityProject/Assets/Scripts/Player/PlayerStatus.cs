using System;
using UnityEngine;
public class PlayerStatus : MonoBehaviour
{
    public static Action<GameObject> NotifyPlayerDead;

    private float life;
    private float maxLife;
    private float speed;
    private bool alive;
    private float weight;
    private float stamina;
    private bool isEffectActive;


    private void Start()
    {
        Sword.NotifySwordCollision += TakeDamage;
    }

    public void Logout()
    {
        // Logout from session
    }

    private void Heal(){}
    private void ChangeSpeed(){}
    private void TakeDamage(GameObject collider){
        if (gameObject.Equals(collider)){
            this.life -= damage;
            if (this.life <= 0){
                alive = false;
                NotifyPlayerDead?.Invoke(gameObject);
            }
        }
    }
    public void Walk(float walkSpeed){}
}
