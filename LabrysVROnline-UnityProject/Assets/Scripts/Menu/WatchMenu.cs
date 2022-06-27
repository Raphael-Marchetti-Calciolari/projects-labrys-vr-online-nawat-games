using System;
using UnityEngine;


namespace Menu
{
    public class WatchMenu : MonoBehaviour

    {
        public GameObject parentPanel;
        public GameObject targetPanel;
        [SerializeField] private Button[] activators;
        

        private void OnButtonClicked()
        {
            foreach (var button in activators)
            {
                Console.WriteLine("Evento Funcionando");
                Debug.Log("Evento funcionando");
                button.GetComponent<Button>().NotifyButtonPressed += ChangeMenu;
            }
        }
        private void ChangeMenu()
        {
            targetPanel.SetActive(true);
            parentPanel.SetActive(true);
            
        }
       
    }
}