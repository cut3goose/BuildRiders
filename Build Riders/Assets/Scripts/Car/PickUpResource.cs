using UnityEngine;

public class PickUpResource : MonoBehaviour
{
    private int Money = 0;
    private int Brick = 0;
    private int Wood = 0;
    private int Concrete = 0;

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.collider.tag)
        {
            case "Money":
                Money += 1;
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
