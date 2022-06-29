using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicViewPanel : MonoBehaviour
{
    public GameObject listItemPrefab;
    public Transform listItemHolder;
    public int numOfListItems;

    public void Start()
    {
        for (int i  = 0; i  < numOfListItems; i ++)
        {
            Instantiate(listItemPrefab, listItemHolder);
        }
    }
}
