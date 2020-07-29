using UnityEngine;

public class PickUpResource : MonoBehaviour
{
    private int Coin = 0;
    private int Brick = 0;
    private int Wood = 0;
    private int Concrete = 0;

    string resourceName;

    void Start()
    {
        resourceName = gameObject.name;
        Debug.Log(resourceName);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (resourceName == "Coin")
            {
                Coin += 1;
                Destroy(gameObject);
            }

            if (resourceName == "Brick")
            {
                Brick += 1;
                Destroy(gameObject);
            }

            if (resourceName == "Wood")
            {
                Wood += 1;
                Destroy(gameObject);
            }

            if (resourceName == "Concrete")
            {
                Concrete += 1;
                Destroy(gameObject);
            }
        }
    }
}
