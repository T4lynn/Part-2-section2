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
    
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        dark_red = sprite.color;
    }
    private void OnMouseDown()
    {
        Selected(true);
    }
    private void Selected(bool selected)
    {
        if (selected) { sprite.color = nice_green; } else { sprite.color = dark_red;}
        
    }
}
