using UnityEngine;

public class OpenShop : MonoBehaviour
{
    GameObject shopWindow;
    void Start()
    {
        shopWindow = GameObject.Find("ShopWindow");
        shopWindow.SetActive(false);
    }

    public void Open()
    {
        shopWindow.SetActive(true);
    }
}
