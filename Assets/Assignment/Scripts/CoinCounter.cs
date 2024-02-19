using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class CoinCounter : MonoBehaviour
{
    public int coin;
   public TMP_Text cointext;

    public void restartcoin()
    {
        coin = 0;
    }
    
    void Start()
    {
        coin = 0;
    }
    void Update()
    {
        cointext.SetText("coins: "+ coin);
    }
    public void addcoins()
    {
        coin++;
    }
}
