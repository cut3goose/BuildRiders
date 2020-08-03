using UnityEngine;

public class ObstacleCrash : MonoBehaviour
{
    public GameObject _GameManager;
    public GameObject player;
    public PlayerBehaviour playerBehaviour;

    private void Start()
    {
        player = gameObject;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            playerBehaviour.SetPlayerDead();

            //Car.GetComponent<Rigidbody>().AddExplosionForce();  можно добавить взрыв после столкновения, чтобы машинка падала на бок
        }
    }
}
