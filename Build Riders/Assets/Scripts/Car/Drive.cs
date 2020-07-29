using UnityEngine;

public class Drive : MonoBehaviour
{
    public Rigidbody carRb;

    public float leftForce = 42f;
    public float rightForce = 50f;
    public float forwardForce = 80f;

    Quaternion turnRight = Quaternion.Euler(0, 25 ,0);
    Quaternion turnLeft = Quaternion.Euler(0, -25, 0);
    public float turnSpeed = 100f;

    void Start()
    {
    }

    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            carRb.AddForce(rightForce * Time.deltaTime, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
            transform.rotation = Quaternion.Lerp(transform.rotation, turnRight, turnSpeed * Time.deltaTime);
        }
        else
        {
            carRb.AddForce(-leftForce * Time.deltaTime, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
            transform.rotation = Quaternion.Lerp(transform.rotation, turnLeft, turnSpeed * Time.deltaTime);
        }
    }
}
