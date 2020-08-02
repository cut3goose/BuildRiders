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
    public Drive DriveScript;

    /// <summary>
    /// Состояния игрока и положений в сцене
    /// </summary>
    public enum PlayerStateAtMoment { Idle, Dead, Alive};
    public PlayerStateAtMoment playerState = PlayerStateAtMoment.Idle;

    public GameObject Player;
    private Vector3 deathPosition;

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
        playerState = PlayerStateAtMoment.Alive;
    }

    public void SetPlayerDead(Vector3 DeathPosition)
    {
        playerState = PlayerStateAtMoment.Dead;
        this.deathPosition = DeathPosition;

        Invoke("OpenDeathMenu", 1f);
    }


    public void DeathMenu_AnotherTry()
    {
        ShowAd();
        DeathMenu.SetActive(false);

        Player.transform.rotation = Quaternion.Euler(0, 0, 0);
        playerState = PlayerStateAtMoment.Alive;
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
        playerState = PlayerStateAtMoment.Idle;
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
