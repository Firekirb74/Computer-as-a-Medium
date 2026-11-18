using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 10;
    public GameObject deathUI;
    public GameObject enemy;
    public BoxCollider2D enemyCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Death();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sword"))
        {
            enemyHealth -= 10;
        }
        else if (other.CompareTag("Fireball"))
        {
            enemyHealth -= 5;
        }
    }

    void Death()
    {
        if (enemyHealth <= 0)
        {
            Destroy(enemyCollider);
            enemy.SetActive(false);
            StartCoroutine(DeathText());
            
            
        }
    }

    IEnumerator DeathText()
    {
        deathUI.SetActive(true);
        yield return new WaitForSeconds(1f);
        deathUI.SetActive(false);
        Destroy(gameObject);
    }
}
