using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    GameObject settingsCanvas;
    void Start()
    {
        settingsCanvas = GameObject.Find("SettingsWindow");
        settingsCanvas.SetActive(false);
    }
    public void OpenSet()
    {
        settingsCanvas.SetActive(true);
    }
}
