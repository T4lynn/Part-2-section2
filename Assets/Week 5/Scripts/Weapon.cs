using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction;
    public float speed = 3;
    void Start()
    {
        GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
       // rb.MovePosition()
    }
}
