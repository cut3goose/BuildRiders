using UnityEngine;
public class PlayerBehaviour : MonoBehaviour
{
    /// <summary>
    /// Состояния игрока и данные о нем
    /// </summary>
    public enum PlayerStateAtMoment { Idle, Dead, Alive };
    private PlayerStateAtMoment playerState = PlayerStateAtMoment.Idle;

    private Vector3 deathPosition;
    public Rigidbody playerRb;
    private GameObject player;

    public GameObject _GameManager;
    
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
        player = gameObject;
    }

    void FixedUpdate()
    {
        switch (playerState)
        {
            case PlayerStateAtMoment.Idle:
                transform.position = Vector3.Lerp(transform.position, transform.position + forwardVector, idleSpeed * Time.deltaTime);
                break;

            case PlayerStateAtMoment.Alive:
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

    public void SetPlayerDead()
    {
        playerState = PlayerStateAtMoment.Dead;
        this.deathPosition = player.transform.position;

        Invoke("empty", 1f);
        _GameManager.GetComponent<GameBehaviour>().OpenDeathMenu();
    }

    public void SetPlayerAlive()
    {
        player.transform.rotation = Quaternion.Euler(0, 0, 0);

        playerState = PlayerStateAtMoment.Alive;
    }

    public void SetPlayerIdle()
    {
        playerState = PlayerStateAtMoment.Idle;
    }
}