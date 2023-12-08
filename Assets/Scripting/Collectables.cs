using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{

      
    private void OnTriggerEnter(Collider other)
    {

        Player player = other.GetComponent<Player>();
  

        if (player != null)
        {
            player.CoinsCollected();
            gameObject.SetActive(false);


        }
    }
}
