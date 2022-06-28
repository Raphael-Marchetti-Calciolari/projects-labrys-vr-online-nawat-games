using System;
using UnityEngine;

public class Button : MonoBehaviour
{
    public static string buttonClassTag = "Button";
    public event Action NotifyButtonPressed;
    
    private void Start(){
        if (!gameObject.tag.Equals(buttonClassTag)) Console.WriteLine($"Button instance ${gameObject} has no tag or wrong tag attributed!");
    }

    public void PressButton()
    {
        NotifyButtonPressed?.Invoke();
    }
}