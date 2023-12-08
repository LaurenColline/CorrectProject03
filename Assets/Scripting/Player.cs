using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //collects coins 
    public int NumberOfCoins { get; private set; }

    public int playerInstance;

    public UnityEvent<Player> OnCoinCollected;

  //  public void InstantiatePlayer()
  //  {
        // Method implementation
       // playerInstance.InstantiatePlayer();
   // }
    public void CoinsCollected()
    {
        NumberOfCoins++;
        OnCoinCollected.Invoke(this);
    }

}
