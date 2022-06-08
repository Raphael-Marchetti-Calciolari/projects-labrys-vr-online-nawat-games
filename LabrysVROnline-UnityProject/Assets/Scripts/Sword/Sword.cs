using System;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public static string swordClassTag = "Sword";

    private void Start()
    {
        if (!gameObject.tag.Equals(swordClassTag)) Console.WriteLine($"Sword instance ${gameObject} has no tag attributed!");
    }

}
