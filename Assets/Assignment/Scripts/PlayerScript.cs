using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Unity.Mathematics;
using Unity.VisualScripting.AssemblyQualifiedNameParser;
using UnityEditor.Sprites;


public class PlayerScript : MonoBehaviour
{
    Vector2 moveto;
    float speed = 3f;
    public int coin;
    Rigidbody2D rb;
    Vector2 motion;
    Animator animator;
    Vector2 thruholepos;
    public AnimationCurve curve;
    float interpolation;
    SpriteRenderer sprite;
    float timer;
    bool triggerlerp;

    // resets the position of the player, and loads the first scene
    public void restartpos()
    {
        SceneManager.LoadScene(5);
        rb.position = Vector2.zero;
        moveto = Vector2.zero;
        
    }
    void Start()
    {
        //initalizes variables, and sets playerposition differently if on scene 4. 
        thruholepos = new Vector2(-4, -1);
        int currentscene = SceneManager.GetActiveScene().buildIndex;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        triggerlerp = false;

        if (currentscene == 4)
        {
            rb.position = thruholepos;
        }
      
    }
    void Update()
    {
        //when the left mousebutton is pressed, it sets the vector2 moveto to whereever
        //was clicked. Won't work if you're clicking on UI or if your sprite colour is beginning to change
        //(like when the lerp is happening). 
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && sprite.color == Color.white)
            {
            moveto = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log(moveto);
           
            }
        //sets animator parameters to motion's x and y.
        animator.SetFloat("vertical", motion.y);
        animator.SetFloat("horizontal", motion.x);

        //if the variable triggerlerp is true, it does this lerp which turns the playermodel black.
        if (triggerlerp)
        {
            timer += Time.deltaTime;
            interpolation = curve.Evaluate(timer);
            sprite.color = Color.Lerp(Color.white, Color.black, interpolation);

            if (sprite.color == Color.black)
            {
                SceneManager.LoadScene(4);
                triggerlerp = false;
            }
        }
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
    // when the player collides with the edges of the screen, it resets the moveto vector
    //to the player's current position, stopping them.S
    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveto = rb.position;
    }
    //a fuction that holescript1 communicates with to trigger a lerp. 
    public void colourchange()
    {
        triggerlerp = true;
    }
}
