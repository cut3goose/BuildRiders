using UnityEngine;

public class CarIdle : MonoBehaviour
{
    public float interpolateSpeed = 15f;
    public Vector3 forwardVector = new Vector3(0, 0, 1);

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, transform.position + forwardVector, interpolateSpeed * Time.deltaTime);
    }
}
