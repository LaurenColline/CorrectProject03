using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
//collects coins 
 public int NumberOfCoins { get; private set; }

    public UnityEvent<Player> OnCoinCollected;


public void CoinsCollected()
    {
        NumberOfCoins++;
        OnCoinCollected.Invoke(this);
    }

}
