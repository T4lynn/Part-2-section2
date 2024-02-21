using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodballPlayer : MonoBehaviour
{
    public Color dark_red;
    public Color nice_green;
    SpriteRenderer sprite;
    Rigidbody2D rb;
    public float speed;
    
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        dark_red = sprite.color;
        rb = GetComponent<Rigidbody2D>();
        speed = 100;
    }
    private void OnMouseDown()
    {
        FootballPlayerController.setcurrentseletion(this);
    }
    public void Selected(bool selected)
    {
        if (selected) { sprite.color = nice_green; } else { sprite.color = dark_red;}
        
    }
    public void Move(Vector2 direction)
    {
        rb.AddForce(direction * speed, ForceMode2D.Impulse);
    }
}
