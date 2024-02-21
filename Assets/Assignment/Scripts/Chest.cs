using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ChestSprite Found at: https://lowich.itch.io/pixelart-chests 
// CoinSprite Found at: https://ninjikin.itch.io/treasure

public class Chest : MonoBehaviour
{
    public GameObject go;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    //sets the attached component to active on mouse down. 
    private void OnMouseDown()
    {
        go.SetActive(true);
    }
}
