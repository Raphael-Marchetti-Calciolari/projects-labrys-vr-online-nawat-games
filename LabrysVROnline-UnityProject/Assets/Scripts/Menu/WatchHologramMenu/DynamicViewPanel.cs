using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Menu;
using UnityEngine;
using UnityEngine.UI;

public class DynamicViewPanel : MonoBehaviour
{
    public GameObject listItemPrefab;
    public Transform listItemHolder;
    //public int numOfListItems;
    [SerializeField] int friend_count = 5;
    public Text text;
    [SerializeField]public Friend[] friend; 


    public void Awake()
    {
        if (friend_count > 0)
        {
            for (int i = 0; i < friend_count; i++) // Substituir numOflistItems para friend_count
            {
                //listItemPrefab.GetComponentInChildren<Text>().text = friend[i].friendName;
                Instantiate(listItemPrefab, listItemHolder);

            }
            
        }

    }

    public void Start()
    {
        for (int i = 1; i < friend_count; i++)
        {
            listItemPrefab.GetComponentInChildren<Text>().text = friend[i].friendName;
        }
    }
    public void set_Friends(Friend[] friend)
    {
        this.friend = friend;
    }

}
