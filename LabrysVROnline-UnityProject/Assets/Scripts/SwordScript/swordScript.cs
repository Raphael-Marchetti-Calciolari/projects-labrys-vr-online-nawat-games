using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class swordScript : MonoBehaviour
{
    public consumableScript swordSabotage;

    void Start()
    {
        GameObject c = GameObject.FindGameObjectWithTag("Consumable");
        swordSabotage = c.GetComponent<consumableScript>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Consumable"))
        {
            swordSabotage.isSabotaged = true;
        }
    }
}
