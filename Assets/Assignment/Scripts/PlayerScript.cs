using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class PlayerScript : MonoBehaviour
{
    Vector2 moveto;
    float speed = 3f;
    public int coin;
    Rigidbody2D rb;
    Vector2 motion;
    Animator animator;

    public void restartpos()
    {
        rb.position = Vector2.zero;
        moveto = Vector2.zero;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        //sets the coin the player has to 0. 
      
    }
    void Update()
    {
        //when the left mousebutton is pressed, it sets the vector2 moveto to whereever
        //was clicked. 
        if (Input.GetMouseButtonDown(0)&& !EventSystem.current.IsPointerOverGameObject())
            {
            moveto = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log(moveto);
           
            }
        //sets animator parameters to motion's x and y.
        animator.SetFloat("vertical", motion.y);
        animator.SetFloat("horizontal", motion.x);
    }
    private void FixedUpdate()
    {
        //the vector 'motion' is set to the destination minus its current position,
        //giving the direction and distance the player has to move
        motion = moveto - (Vector2)transform.position;
        //stops the player of the length of the vector is less than 0.2.
        if (motion.magnitude < 0.1) {
            motion = Vector2.zero;
        }
        //sets the speed the player moves at
        rb.MovePosition(rb.position + motion.normalized * speed * Time.deltaTime);
       // Debug.Log(motion);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveto = rb.position;
    }
}
