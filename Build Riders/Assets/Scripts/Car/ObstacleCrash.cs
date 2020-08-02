using UnityEngine;

public class ObstacleCrash : MonoBehaviour
{
    public GameObject _GameManager;
    public GameObject player;

    //public float switchScreenDelay = 4.0f;

    private void Start()
    {
        player = gameObject;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            SendDeathInfo(player.transform.position);

            //Car.GetComponent<Rigidbody>().AddExplosionForce();  можно добавить взрыв после столкновения, чтобы машинка падала на бок
        }
    }

    private void SendDeathInfo(Vector3 DeathPosition)
    {
        _GameManager.GetComponent<GameBehaviour>().SetPlayerDead(DeathPosition);
    }
    
}
