using UnityEngine;
public class Drive : MonoBehaviour
{
    public Rigidbody playerRb;
    public GameObject _GameManager;
    private GameBehaviour.PlayerStateAtMoment playerState = new GameBehaviour.PlayerStateAtMoment();

    /// <summary>
    /// Силы, прилагаемые к игроку
    /// </summary>
    public float leftForce = 42f;
    public float rightForce = 50f;
    public float forwardForce = 80f;

    /// <summary>
    /// Повороты в стороны
    /// </summary>
    Quaternion turnRight = Quaternion.Euler(0, 25, 0);
    Quaternion turnLeft = Quaternion.Euler(0, -25, 0);
    public float turnSpeed = 100f;

    /// <summary>
    /// Движение во время бездействия
    /// </summary>
    public float idleSpeed = 15f;
    public Vector3 forwardVector = new Vector3(0, 0, 1);

    public void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        playerState = _GameManager.GetComponent<GameBehaviour>().playerState;

        switch (playerState)
        {
            case GameBehaviour.PlayerStateAtMoment.Idle:
                transform.position = Vector3.Lerp(transform.position, transform.position + forwardVector, idleSpeed * Time.deltaTime);
                break;

            case GameBehaviour.PlayerStateAtMoment.Alive:
                Move();
                break;
        }  
    }
    private void Move()
    {
        if (Input.GetButton("Jump"))
        {
            playerRb.AddForce(leftForce * Time.deltaTime, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
            transform.rotation = Quaternion.Lerp(transform.rotation, turnRight, turnSpeed * Time.deltaTime);
        }
        else
        {
            playerRb.AddForce(-leftForce * Time.deltaTime, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
            transform.rotation = Quaternion.Lerp(transform.rotation, turnLeft, turnSpeed * Time.deltaTime);
        }
    }
}