using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSettings : MonoBehaviour
{
    GameObject settingsCanvas;
    void Start()
    {
        settingsCanvas = GameObject.Find("SettingsWindow");
    }
    public void Close()
    {
        settingsCanvas.SetActive(false);
    }
}

