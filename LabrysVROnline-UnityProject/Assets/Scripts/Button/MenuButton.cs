using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MenuButton : MonoBehaviour
{
    public event Action NotifyButtonPressed;
    
    public void PressButtonCustomizado()
    {
        NotifyButtonPressed?.Invoke();
    }
}