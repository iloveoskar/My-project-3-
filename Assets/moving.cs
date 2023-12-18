using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Spawn Variables
    public float playerSetX;
    public float playerSetY;
    public float playerSetZ;
    public new Rigidbody2D rigidbody2D;

    // Movement Variables
    public float playerJumpHeight = 10;
    public float playerSpeed = 5;

    void Start()
    {
        // Player Spawn Point
        transform.position = new Vector3(playerSetX, playerSetY, playerSetZ);
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Player movement
        float horizontalInput = Input.GetAxis("Horizontal");
        rigidbody2D.velocity = new Vector2(horizontalInput * playerSpeed, rigidbody2D.velocity.y);

        // Jumping
        if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(rigidbody2D.velocity.y) < 0.01f)
        {
            rigidbody2D.AddForce(Vector2.up * playerJumpHeight, ForceMode2D.Impulse);
        }
    }
}