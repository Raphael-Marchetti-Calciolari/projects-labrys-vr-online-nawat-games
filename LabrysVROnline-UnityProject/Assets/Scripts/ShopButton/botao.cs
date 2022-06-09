using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//https://www.youtube.com/watch?v=Oie-G5xuQNA

public class ButtonInfo : MonoBehaviour
{
    public int EquipmentID;
    public Text PriceTXT;
    public Text QuantityTXT;
    public GameObject ShopMenu;

    void Update()
    {
        PriceTXT.text = "Custo: $" + ShopMenu.GetComponent<ShopMenu>().equipment[2, EquipmentID].ToString();
        //QuantityTXT.text = ShopMenu.GetComponent<ShopMenu>().equipment[3, EquipmentID].ToString();
        //talvez nao use o de cima
    }
}