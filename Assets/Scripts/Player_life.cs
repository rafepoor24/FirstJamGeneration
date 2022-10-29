using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//para realizar la transicion en escenas
using UnityEngine.SceneManagement;
public class Player_life : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    public AudioSource deathSound;
   
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("spike") || collision.gameObject.CompareTag("saw"))
        {
            Die();
        }
    }

    private void Die()
    {
        deathSound.Play();
        rb.bodyType=RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
