using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restartscript : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;
    private void Start()
    {
    }
    public void thisrestartspos()
    {
    go.SendMessage("restartpos");

    }
    public void thisrestartscoin()
    {
        go2.SendMessage("restartcoin");
    }
}
