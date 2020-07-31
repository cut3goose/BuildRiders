using UnityEngine;
using System.Collections.Generic;

public class ObstacleCrash : MonoBehaviour
{
    public GameObject Car;

    public float switchScreenDelay = 4.0f;
    public GameObject deathScreenCanvas;
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Car.GetComponent<Drive>().enabled = false;
            Car.transform.position = Vector3.zero;

            Invoke("chooseScreen", switchScreenDelay);
            //Car.GetComponent<Rigidbody>().AddExplosionForce();  можно добавить взрыв после столкновения, чтобы машинка падала на бок
        }
    }
    
    void chooseScreen()
    {
        openDeathScreen();
    }

    void openDeathScreen()
    {
        deathScreenCanvas.SetActive(true);
        Invoke("DestroyObstacle", 1f);
    }

    void DestroyObstacle()
    {
        Destroy(gameObject);
    }
}
