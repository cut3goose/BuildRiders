using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform carTransform;
    public float y = 15f;
    public float z = -15f;

    Vector3 distanceBetween;
    void Start()
    {
        distanceBetween = new Vector3(0, y, z);
    }

    void Update()
    {
        transform.position = carTransform.position + distanceBetween;
    }
}
