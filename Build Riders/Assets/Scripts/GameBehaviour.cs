using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    /// <summary>
    /// Холсты от всех элементов меню
    /// </summary>
    public GameObject MainMenu;
    public GameObject SettingsMenu;
    public GameObject ShopMenu;
    public GameObject DeathMenu;
    //public GameObject VictoryMenu;
    //public GameObject OpenCaseMenu;

    public GameObject PlayUI;
    public PlayerBehaviour PlayerBehaviour;


    void Start()
    {
    }

    public void ShowAd()
    {

    }

    public void StartGame()
    {
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        ShopMenu.SetActive(false);
        
        PlayUI.SetActive(true);

        PlayerBehaviour.SetPlayerAlive();
    }

    public void DeathMenu_AnotherTry()
    {
        ShowAd();
        DeathMenu.SetActive(false);

        PlayerBehaviour.SetPlayerAlive();
    }

    public void OpenDeathMenu()
    {
        ShowAd();
        DeathMenu.SetActive(true);
    }

    public void OpenMainMenu()
    {
        MainMenu.SetActive(true);
        DeathMenu.SetActive(false);

        PlayerBehaviour.SetPlayerIdle();
        //нужен старт нового уровня
    }

    public void ShopSwitch()
    {
        ShopMenu.SetActive(!ShopMenu.activeSelf); 
    }

    public void SettingsSwitch()
    {
        SettingsMenu.SetActive(!SettingsMenu.activeSelf);
    }
}
