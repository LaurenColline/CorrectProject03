using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private Renderer myMaterial;
    public float colorDuration = 10f; // Set the duration of the color change

    //private bool isPlayerInRange = false;
          private Color initialColor;
          //private float colorTimer;

  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //isPlayerInRange = true;
            myMaterial.material.color = Color.green;
            Debug.Log("Player entered the trigger zone.");
        }
    }
  
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myMaterial.material.color = Color.red;
            Debug.Log("Player entered the trigger zone.");
        }
    }

 
}
