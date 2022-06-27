using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class shieldScript : MonoBehaviour
{
    private int shieldHitpoints;
    private int shieldDamage;
    public shieldScript shieldObj; 
    Collider m_Collider;

    void Start()
    {
        m_Collider = GetComponent<Collider>();
    }

       private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Sword")
        {
            shieldHitpoints -= shieldDamage;
        }
    }

    void Update()
    {
        int shieldDamage = shieldObj.GetComponent<playerScript>().playerDamage;
        if (shieldHitpoints <= 0)
        {
            m_Collider.enabled = !m_Collider.enabled;
        }
    }
}
