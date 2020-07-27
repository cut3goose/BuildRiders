using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public Rigidbody carRb = new Rigidbody();
    int car_pos = 2;
    int kozla = 2;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") && car_pos != 1)
        {
            car_pos = 
            //carRb.AddForce()
        }
        Debug.Log(kozla);
    }
}
