using UnityEngine;

public class PickUpResource : MonoBehaviour
{
    private int Coin = 0;
    private int Brick = 0;
    private int Wood = 0;
    private int Concrete = 0;

    string resourceTag;
    void Start()
    {
        resourceTag = gameObject.tag;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            switch (resourceTag)
            {
                case "Coin":
                    Coin += 1;
                    break;
                case "Brick":
                    Brick += 1;
                    break;
                case "Wood":
                    Wood += 1;
                    break;
                case "Concrete":
                    Concrete += 1;
                    break;
            }
            Destroy(gameObject);
        }
    }
}
