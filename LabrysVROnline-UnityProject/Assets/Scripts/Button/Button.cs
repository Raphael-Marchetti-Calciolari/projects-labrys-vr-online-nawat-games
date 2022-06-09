using System;
using UnityEngine;

public class Button : MonoBehaviour
{
    public event Action NotifyButtonPressed;
    
    public void PressButton()
    {
        NotifyButtonPressed?.Invoke();
    }
}