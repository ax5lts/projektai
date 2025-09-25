using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool isGrounded;
    public SpriteRenderer spriteRenderer;
    public Sprite[] characterSprites;
    private int spriteIndex = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("AnimateSprite", 0.1f, 0.1f);
    }

    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void AnimateSprite()
    {
        if (characterSprites.Length > 0)
        {
            spriteIndex = (spriteIndex + 1) % characterSprites.Length;
            spriteRenderer.sprite = characterSprites[spriteIndex];
        }
    }
}
