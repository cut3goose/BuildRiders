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
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider != null)
        {
            switch (collision.collider.tag)
            {
                case "Coin":
                    Coin += 1;
                    Destroy(collision.collider.gameObject);
                    break;
                case "Brick":
                    Brick += 1;
                    Destroy(collision.collider.gameObject);
                    break;
                case "Wood":
                    Wood += 1;
                    Destroy(collision.collider.gameObject);
                    break;
                case "Concrete":
                    Concrete += 1;
                    Destroy(collision.collider.gameObject);
                    break;
            }
        }
    }
}
