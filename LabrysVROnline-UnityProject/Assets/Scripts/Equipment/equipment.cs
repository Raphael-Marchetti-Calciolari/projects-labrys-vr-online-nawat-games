using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equipment : MonoBehaviour
{
    public static string equipmentClassTag = "Equipment";

    public float price;
    public char name;
    public char model;
    public char type;
    public bool gearBought = false;

    private void Start(){
        if (!gameObject.tag.Equals(equipmentClassTag)) Debug.Log($"Equipment instance ${gameObject} has no tag or wrong tag attributed!");
    }
}
