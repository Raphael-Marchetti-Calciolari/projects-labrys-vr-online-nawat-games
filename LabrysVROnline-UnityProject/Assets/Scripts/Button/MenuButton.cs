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
        Debug.Log("Botao apertado");
        NotifyButtonPressed?.Invoke();
        Debug.Log("Evento emitido");
    }
}