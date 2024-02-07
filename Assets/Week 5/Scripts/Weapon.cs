using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction;
    public float speed = 5;
    float timer = 0;
    void Start()
    {
       rb =  GetComponent<Rigidbody2D>();
        direction = Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 5)
        {
            Destroy(gameObject);
        }
        
           timer = timer + Time.deltaTime;
        

    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("takeDamage", 1);
        Destroy(gameObject);
        
    }
}
