using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;      public Rigidbody2D rb;  
    public float flipDuration = 0.2f;  
    public float gravityScale = 5f;  

    private bool isFlipped = false;
    private float lowY = -0.57f;
    private float highY = -1.71f;

    void Start()
    {
        
        if (spriteRenderer == null) spriteRenderer = GetComponent<SpriteRenderer>();
        if (rb == null) rb = GetComponent<Rigidbody2D>();

        if (rb == null)
        {
            Debug.LogError("Rigidbody2D is missing from the player!", this);
        }
        else
        {
            rb.gravityScale = gravityScale; 
        }

      //Y =-1.14
        transform.position = new Vector2(transform.position.x, lowY);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FlipPlayer();
        }
    }

    void FlipPlayer()
    {
        isFlipped = !isFlipped;

        // perkeisti gravitacija
        rb.gravityScale = isFlipped ? -gravityScale : gravityScale;

        
        StartCoroutine(SmoothMove());

        
        StartCoroutine(SmoothRotation());

        //perkeisti spalva (juoda/balta)
        if (spriteRenderer) spriteRenderer.color = isFlipped ? Color.black : Color.white;
    }

    IEnumerator SmoothMove()
    {
        float elapsedTime = 0f;
        Vector2 startPos = transform.position;
        Vector2 targetPos = new Vector2(transform.position.x, isFlipped ? highY : lowY);

        while (elapsedTime < flipDuration)
        {
            transform.position = Vector2.Lerp(startPos, targetPos, elapsedTime / flipDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos; 
    }

    IEnumerator SmoothRotation()
    {
        float elapsedTime = 0f;
        Quaternion startRotation = transform.rotation;
        Quaternion targetRotation = Quaternion.Euler(isFlipped ? 180f : 0f, 0f, 0f);

        while (elapsedTime < flipDuration)
        {
            transform.rotation = Quaternion.Lerp(startRotation, targetRotation, elapsedTime / flipDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.rotation = targetRotation; 
    }
}
