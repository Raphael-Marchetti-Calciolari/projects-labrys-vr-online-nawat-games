using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text PriceTXT;
    public Text QuantityTXT;
    public GameObject ShopManager;


    void Update()
    {
        PriceTXT.text = "Custo : $" + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
        QuantityTXT.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();

        if(ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID] > 0)
        {
            PriceTXT.text = "Item comprado";
        }
    }
}
