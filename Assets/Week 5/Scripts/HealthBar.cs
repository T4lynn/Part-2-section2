using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   public Slider slider;
    float startinghealth;
    public void sethealth()
    {
        startinghealth = PlayerPrefs.GetFloat("Health");
        slider.value = startinghealth;
    }
    public void takeDamage(float damage)
    {
        slider.value -= damage;
    }
}
