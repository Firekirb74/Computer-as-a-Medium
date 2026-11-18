using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class mana : MonoBehaviour
{
    
    public float Speed = 10f;
    public float DestroyTime = 3f;
    public Rigidbody2D rb;
    
    void Start()
    {
       
        rb.linearVelocity = transform.right * Speed;
        Destroy(gameObject, DestroyTime);
    }
    void Update()
    {
        
        
    }
    
    }

