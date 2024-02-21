using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinCounter : MonoBehaviour
{
    public int coin;
   public TMP_Text cointext;

    //resets coins to 0. 
    public void restartcoin()
    {
       // Debug.Log("clicked");
        coin = 0;
    }
    
    // starts the player w 0 coins
    void Start()
    {
        coin = 0;
    }
    // controls the UI 'coin counter' section; displays # of coins.
    void Update()
    {
        cointext.SetText("coins: "+ coin);
    }
    //adds coins. 
    public void addcoins()
    {
        coin++;
    }
}
