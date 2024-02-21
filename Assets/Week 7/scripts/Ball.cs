using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public Rigidbody2D rbkickoff;
    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FootballPlayerController.score++;
        rb.transform.position = rbkickoff.transform.position;
        rb.velocity = Vector2.zero;
    }
}
