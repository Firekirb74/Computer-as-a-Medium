using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;


    public Rigidbody2D rb;

    public SpriteRenderer spriteRenderer;
    public Transform firePoint;
    public Transform sprite;

    public Sprite Wizard_0;
    public Sprite Wizard_1;
    public Sprite Wizard_3;
    public Sprite Wizard_2;

    void Start()
    {
    }
    void Update()
    {
        Movement();
        /*if (transform.localRotation != Quaternion.Euler(0f, 0f, 0f))
        {
            transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }*/
    }
    void Movement()
    {
        // Horizontal Movement
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed;
            spriteRenderer.sprite = Wizard_2;
            sprite.localScale = new Vector3(-1f, 1f, 1f);
            firePoint.rotation = Quaternion.Euler(0f, 0f, 180f);
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            spriteRenderer.sprite = Wizard_2;
            sprite.localScale = new Vector3(1f, 1f, 1f);
            firePoint.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else
        {
            speedX = 0;
        }
        // Vertical Movement
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            spriteRenderer.sprite = Wizard_0;
            firePoint.rotation = Quaternion.Euler(0f, 0f, 90f);
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            spriteRenderer.sprite = Wizard_1;
            firePoint.rotation = Quaternion.Euler(0f, 0f, -90f);
        }
        else
        {
            speedY = 0;
        }
        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
