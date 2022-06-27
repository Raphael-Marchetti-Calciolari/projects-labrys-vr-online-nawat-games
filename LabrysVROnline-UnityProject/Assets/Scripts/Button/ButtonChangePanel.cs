using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonChangePanel : MonoBehaviour
{
    private Button button;
    public GameObject parentPanel;
    public GameObject targetPanel;


    public void Awake()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        parentPanel.SetActive(false);
        targetPanel.SetActive(true);
    }
}
