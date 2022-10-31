using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public AudioSource finishSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        finishSound=GetComponent<AudioSource>();    

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "Player")
        {
            finishSound.Play();
            CompleteLevel();
        }
    }
    private void CompleteLevel()
    {

    }
}
