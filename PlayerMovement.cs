using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 7.0f;
    [SerializeField]
    private float _jumpForce = 10f;
    [SerializeField]
    private LayerMask groundLayer; 
    [SerializeField]
    private float flipYPosition = 3.5f; 

    private Rigidbody2D rb;
    private int lives = 15;
    private bool isFlipped = false; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D is missing from the player!", this);
        }
    }

    void Update()
{
    
    float horizontalInput = Input.GetAxis("Horizontal");
    rb.velocity = new Vector2(horizontalInput * _speed, rb.velocity.y);

    // Flip when pressing Space
    if (Input.GetKeyDown(KeyCode.Space))
    {
        FlipPlayer();
    }

   
    if (Input.GetKeyDown(KeyCode.W) && IsGrounded())
    {
        
        float jumpVelocity = isFlipped ? -_jumpForce : _jumpForce;
        rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
    }
}

    void FlipPlayer()
    {
        isFlipped = !isFlipped;

      
        transform.position = new Vector2(transform.position.x, isFlipped ? flipYPosition : -flipYPosition);

  
        rb.gravityScale *= -1;

       
        transform.Rotate(0, 0, 180);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            lives--;
            Debug.Log("Collided with Spike! Lives left: " + lives);

            if (lives > 0)
            {
                transform.position = new Vector2(transform.position.x, isFlipped ? flipYPosition : -flipYPosition);
                rb.velocity = Vector2.zero;
            }
            else
            {
                Debug.Log("Game Over! Restarting...");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    private bool IsGrounded()
    {
        
        Vector2 direction = isFlipped ? Vector2.up : Vector2.down;
        return Physics2D.Raycast(transform.position, direction, 0.1f, groundLayer);
    }
    
}
