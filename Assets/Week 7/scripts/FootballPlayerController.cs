using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballPlayerController : MonoBehaviour
{
    public Slider chargeslider;
    float charge;
    public float maxcharge;
    Vector2 direction;
    public static FoodballPlayer currentselection { get; private set; }

    public static void setcurrentseletion(FoodballPlayer player)
    {
        if (currentselection != null)
        {
            currentselection.Selected(false);
        }
        currentselection = player;
        currentselection.Selected(true);
    }
    private void FixedUpdate()
    {
        if (direction != Vector2.zero) {
            currentselection.Move(direction);
            direction = Vector2.zero;
        }
    }
    private void Update()
    {
        if (currentselection == null) return;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            charge = 0;
            direction = Vector2.zero;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            charge += Time.deltaTime;
            charge = Mathf.Clamp(charge, 0, maxcharge);
            chargeslider.value = charge;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            direction = ((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)currentselection.transform.position).normalized * charge;

        }
    }
}
