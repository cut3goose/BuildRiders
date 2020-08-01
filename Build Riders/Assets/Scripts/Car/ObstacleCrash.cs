using UnityEngine;
using System.Collections.Generic;

public class ObstacleCrash : MonoBehaviour
{
    public GameObject _GameManager;
    public GameObject car;

    public float switchScreenDelay = 4.0f;
    public GameObject deathScreenCanvas;

    private void Start()
    {
        car = gameObject;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            car.GetComponent<Drive>().enabled = false;

            Invoke("chooseScreen", switchScreenDelay);
            //Car.GetComponent<Rigidbody>().AddExplosionForce();  можно добавить взрыв после столкновения, чтобы машинка падала на бок
        }
    }

    void SendDeathInfo()
    {
        _GameManager.
    }
    
}
