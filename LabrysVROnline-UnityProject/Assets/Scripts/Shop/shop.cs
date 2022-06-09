using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//https://www.youtube.com/watch?v=Oie-G5xuQNA

public class ShopMenu : MonoBehaviour
{
   public float wallet;
   public int[,] equipment = new int[5,5];
   public Text WalletTXT;
   public Text gearBoughtText;
   public bool canBuy = true;
   public bool menuActive = true;
   public EquipmentScript equipmentBool;

   void Start()
   {
       WalletTXT.text = "Carteira:" + wallet.ToString();
       GameObject e = GameObject.FindGameObjectWithTag("Equipment");
       equipmentBool = e.GetComponent<EquipmentScript>();

       //ID
       equipment[1, 1] = 1;
       equipment[1, 2] = 2;
       equipment[1, 3] = 3;
       equipment[1, 4] = 4;

       //Custo (valor placeholder)
       equipment[2, 1] = 10;
       equipment[2, 2] = 20;
       equipment[2, 3] = 30;
       equipment[2, 4] = 40;

       //Quantidade - talvez nao use(?)
       equipment[3, 1] = 0;
       equipment[3, 2] = 0;
       equipment[3, 3] = 0;
       equipment[3, 4] = 0;
   }

   public void NotifyMenuSelection(Collision collision)
   {
       if(collision.gameObject.tag.Equals("Player"))
        {
            menuActive = true;
        }
   }

   public void BuyEquipment()
   {
       GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

       if (wallet >= equipment[2, ButtonRef.GetComponent<ButtonInfo>().EquipmentID] && menuActive .Equals(true))
       {
           wallet -= equipment[2, ButtonRef.GetComponent<ButtonInfo>().EquipmentID]; //mexe no dinheiro
           //equipment[3, ButtonRef.GetComponent<ButtonInfo>().EquipmentID]++; //aumenta a quantidade
           WalletTXT.text = "Carteira:" + wallet.ToString(); //atualiza a carteira
           //ButtonRef.GetComponent<ButtonInfo>().QuantityTXT.text = equipment[3, ButtonRef.GetComponent<ButtonInfo>().EquipmentID].ToString(); //atualizaria texto do botao se desse pra comprar varias vezes, provavelmente n vou usar
           equipmentBool.gearBought = true;
       }

       if (equipmentBool.gearBought.Equals(true))
       {
           gearBoughtText.text = "Comprado";
           canBuy = false;
       }
   }
}
