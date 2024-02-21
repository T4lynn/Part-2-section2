using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoleScript1 : MonoBehaviour
{
    public GameObject player;
  
    // on trigger enter sends a message that changes a variable in Playerscript. 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.SendMessage("colourchange");
    }
}
