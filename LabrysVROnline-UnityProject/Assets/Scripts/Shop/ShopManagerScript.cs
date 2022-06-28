using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{
    public int[,] shopItems = new int[5,5];
    public Equipment[] items; // Todos os equipamentos cadastrados na loja - provavelmente scriptable objects
    public float coins;
    public Text CoinsTXT;

    private PlayerProfile playerProfileRef;


    void Start()
    {
        foreach(var equip in playerProfileRef.GetEquipment()){
            // Se Equip do catálogo == Equip comprado pelo player
            // Equip do catálogo -> não mostra o equipamento que o player possui
        }

        CoinsTXT.text = "Carteira:" + coins.ToString();

        //ID
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //Custo
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;

        //Quantidade
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID] <= 0)
        {

            if (coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
            {
                coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];

                shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;

                CoinsTXT.text = "Carteira:" + coins.ToString();

                ButtonRef.GetComponent<ButtonInfo>().QuantityTXT.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();


            }
        }
    }
}
