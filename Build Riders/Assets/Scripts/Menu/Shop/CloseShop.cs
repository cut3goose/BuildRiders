using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseShop : MonoBehaviour
{
    GameObject shopWindow;
    void Start()
    {
        shopWindow = GameObject.Find("ShopWindow");
    }

    public void Close()
    {
        shopWindow.SetActive(false);
    }
}
