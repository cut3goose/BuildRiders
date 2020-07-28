using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public Rigidbody carRb = new Rigidbody();
    public float leftForce = 8f;
    public float rightForce = 15f;
    public float forwardForce = 20f;

    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            carRb.AddForce(rightForce * Time.deltaTime, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else
        {
            carRb.AddForce(-leftForce * Time.deltaTime, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
