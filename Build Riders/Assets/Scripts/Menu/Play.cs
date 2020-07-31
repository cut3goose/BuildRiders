using UnityEngine;

public class Play : MonoBehaviour
{
    GameObject mainMenuCanvas;
    GameObject playUICanvas;

    GameObject carObject;
    void Start()
    {
        mainMenuCanvas = GameObject.Find("MainMenu");
        playUICanvas = GameObject.Find("PlayUI");
        playUICanvas.gameObject.SetActive(false);

        carObject = GameObject.Find("Car");
        carObject.GetComponent<Drive>().enabled = false;
        //idle script already enabled
    }
    public void PlayMode()
    {
        mainMenuCanvas.gameObject.SetActive(false);
        playUICanvas.gameObject.SetActive(true);

        carObject.GetComponent<Drive>().enabled = true;
    }
}
