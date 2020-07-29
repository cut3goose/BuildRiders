using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Play : MonoBehaviour
{
    public Canvas MainMenuCanvas;
    public Canvas PlayUICanvas;

    public void PlayMode()
    {
        MainMenuCanvas.enabled = false;
        PlayUICanvas.enabled = true;
        Debug.Log("Oleg");
    }
}
