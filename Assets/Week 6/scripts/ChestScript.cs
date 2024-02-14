using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        int currentsceneindex = SceneManager.GetActiveScene().buildIndex;
        int nextsceneindex = (currentsceneindex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextsceneindex);
    }
}
