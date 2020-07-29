using UnityEngine;

public class ObstacleCrash : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject Car = GameObject.Find("Car");
            Car.GetComponent<Drive>().enabled = false;
            //Car.GetComponent<Rigidbody>().AddExplosionForce();  можно добавить взрыв после столкновения, чтобы машинка падала на бок
        }
    }
}
