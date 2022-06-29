using System;
using UnityEngine;


namespace Menu
{
    public class WatchMenu : MonoBehaviour

    {
        public GameObject parentPanel;
        public GameObject targetPanel;
        [SerializeField] private MenuButton[] activators;
        

        private void Start()
        {
            foreach (var menubutton in activators)
            {
                menubutton.NotifyButtonPressed += ChangeMenu;
                Debug.Log("Evento Cadastrado");
            }
        }
        private void ChangeMenu()
        {
            Debug.Log("Ativado pelo evento");
            targetPanel.SetActive(true);
            parentPanel.SetActive(false);
            
        }
       
    }
}