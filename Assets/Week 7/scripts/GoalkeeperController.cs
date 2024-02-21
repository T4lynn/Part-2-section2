using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalkeeperController : MonoBehaviour
{
    Rigidbody2D rb;
   public Rigidbody2D rbcontroller;
    public Rigidbody2D rbselected;
    Vector2 currentvector;

    private void Start()
    {
        FoodballPlayer.currentselection.transform = currentvector;
        rb = GetComponent<Rigidbody2D>();
    }

}
