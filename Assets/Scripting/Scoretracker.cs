using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoretracker : MonoBehaviour
{
    private TextMeshProUGUI coinText;

    private void Start()
    {
        coinText = GetComponent<TextMeshProUGUI>();

    }

    public void UpdateCoinText(Player player)

    {
        coinText.text =player.NumberOfCoins.ToString();

    }

}
