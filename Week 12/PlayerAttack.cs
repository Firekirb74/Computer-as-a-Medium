using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    public GameObject bulletPrefab;
    public int Mana = 100;
    public TMP_Text manatext;
    public Transform firePoint;
    public Transform weapons;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manatext.text = "Mana: " + Mana;
    }

    // Update is called once per frame
    void Update()
    {
        manatext.text = "Mana: " + Mana;
        Attack();
        Shoot();
        
    }

    void Attack()
    {
        if (Keyboard.current.fKey.isPressed)
        {
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);
        }
    }

    void Shoot()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame && Mana >= 10)
        {
            Mana -= 10;
          
            Instantiate(bulletPrefab, firePoint.position, weapons.rotation);
            
        }
    }
}
