using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public AudioSource itemsCollet;
    private int cherries = 0;
    [SerializeField] public TextMeshProUGUI cherriesText;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
     if(collision.gameObject.CompareTag("cherry"))//Se coloca el nombre del tag asignado al objeto
        {
            //itemsCollet.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text= "Cherries: " + cherries + "/11";
        }
    }
}
