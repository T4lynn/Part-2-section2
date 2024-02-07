using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Knight : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 destination;
    Vector2 movement;
    public float speed = 3;
    Animator animator;
    bool clickingonself = false;
    public float health;
    public float maxhealth = 5;
    bool isdead = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        health = maxhealth;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (isdead) return;
        movement = destination - (Vector2)transform.position;
        if(movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }
        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
    }

    private void Update()
    {
        if (isdead) return;
        if (Input.GetMouseButtonDown(0) && !clickingonself)
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        animator.SetFloat("movement", movement.magnitude);
        if (Input.GetMouseButtonDown (1))
        {
            animator.SetTrigger("Attack");
        }
    }
    private void OnMouseDown()
    {
        if (isdead) return;
        clickingonself=true;
        SendMessage("takeDamage", 1);

    }
    private void OnMouseUp()
    {
        clickingonself=false;
    }
    public void takeDamage(float damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, maxhealth);
        if (health <= 0)
        {
            isdead=true;
            animator.SetTrigger("Death");
        } else
        {
            isdead = false;
            animator.SetTrigger("takedamage");
        }
    }
}
