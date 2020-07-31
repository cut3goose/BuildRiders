using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    public GameObject car;

    public GameObject deathMenuCanvas;
    public GameObject mainMenuCanvas;

    void Start()
    {
        
    }

    public void AdditionalTry()
    {
        //добавить показ рекламы//

        deathMenuCanvas.SetActive(false);

        car.GetComponent<Drive>().enabled = true;
        car.GetComponent<CarIdle>().enabled = false;
    } 

    public void OpenMainMenu()
    {
        car.GetComponent<CarIdle>().enabled = true;
        deathMenuCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }
}
