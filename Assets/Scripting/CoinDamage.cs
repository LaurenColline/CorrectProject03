using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDamage : MonoBehaviour
{
    public healthonplayer healthplayer;
    public int damageAmount = 10;


    private void Start()
    {


    }
    private void Update()
    {

    }
    void OnCollisionEnter3D(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            healthplayer.TakeDamage(damageAmount);
        }
    }


}
    
   // private void OnTriggerEnter(Collider other)
   // {
    ///    if (other.CompareTag("Player"))
     ///   {
            // Damage the player and destroy the collectible.
     ///       other.GetComponent<healthonplayer>().TakeDamage(damageAmount);
       ///     Destroy(gameObject);
       // }
      //  else
      //  {
       //     Debug.LogError("healthonplayer component not found on the Player GameObject.");
     //   }
     //   /*
//    }

//}

//}
