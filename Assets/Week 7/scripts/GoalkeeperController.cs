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
    Vector2 goalievector;
    Vector2 direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        goalievector = rb.transform.position;
    }
    private void Update()
    {
        FootballPlayerController.currentselection.transform.position = currentvector;
    }
    void finddirection()
    {
        direction = (goalievector - currentvector).normalized;
    }

}
