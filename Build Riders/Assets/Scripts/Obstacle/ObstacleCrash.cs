using UnityEngine;

public class ObstacleCrash : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject Car = GameObject.Find("Car");
            Car.GetComponent<Drive>().enabled = false;
            Car.GetComponent<CarIdle>().enabled = true; //нужно перенести это в другое место, активировать после перехода в менюшку смерти
            Car.transform.position = Vector3.zero;
            //Car.GetComponent<Rigidbody>().AddExplosionForce();  можно добавить взрыв после столкновения, чтобы машинка падала на бок
        }
    }
}
