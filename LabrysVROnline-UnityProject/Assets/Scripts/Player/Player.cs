using System;
using UnityEngine;
public class Player : MonoBehaviour
{
    public static string playerClassTag = "Player";
    public int index;

    private void Start()
    {
        if (!gameObject.tag.Equals(playerClassTag)) Console.WriteLine($"Player instance ${gameObject} has no tag or wrong tag attributed!");
    }

    public void Logout()
    {
        // Logout from session
    }
}
