using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public float moveSpeed = 2f; 
    public float destroyX = -10f; 
    private SpriteRenderer spriteRenderer;
    private bool colorChanged = false; 
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();  
        if (spriteRenderer != null)
        {
            spriteRenderer.color = Color.white; 
        }
    }

    void Update()
    {
        
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

       
        if (!colorChanged && transform.position.y <= -1.26f)
        {
            ChangeColorToBlack();
        }

       
        if (transform.position.x <= destroyX)
        {
            Destroy(gameObject);
        }
    }

    void ChangeColorToBlack()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = Color.black;  
            colorChanged = true; 
        }
    }
}
