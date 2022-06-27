using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{
    public int currentLife;
    public int maxLife;
    public int playerDamage;
    public bool isDead;

    void TakeDamage()
    {
        currentLife -= playerDamage;

        if(currentLife <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        isDead.Equals(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Sword")
        {
            TakeDamage();
        }
    }
}
