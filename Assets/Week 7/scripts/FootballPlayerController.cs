using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballPlayerController : MonoBehaviour
{
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
}
