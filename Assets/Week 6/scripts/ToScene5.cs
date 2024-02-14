using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToScene5 : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene5()
    {
        SceneManager.LoadScene(2);
    }
    public void setres1()
    {
        Screen.SetResolution(1600, 900, true);
        Debug.Log("set to 16:9");
    }
    public void setres2()
    {
        Screen.SetResolution(1080, 1920, true);
        Debug.Log("set to HD");
    }
}
