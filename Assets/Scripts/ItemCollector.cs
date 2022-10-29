using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherries=0;
    public TextMeshPro cherriesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
     if(collision.gameObject.CompareTag("cherry"))//Se coloca el nombre del tag asignado al objeto
        {
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text= "Cherries: " + cherries;
        }
    }
}
