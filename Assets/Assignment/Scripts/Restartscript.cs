using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restartscript : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;

    //sends a msg to the first gameobject that triggers 'restartpos' (its in playerscript).
    public void thisrestartspos()
    {
    go.SendMessage("restartpos");

    // same as above, but for coin counter.
    }
    public void thisrestartscoin()
    {
        go2.SendMessage("restartcoin");
    }
}
