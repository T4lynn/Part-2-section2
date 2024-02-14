using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader : MonoBehaviour
{
   public void LoadNextScene()
    {
        int currentsceneindex = SceneManager.GetActiveScene().buildIndex;
        int nextsceneindex = (currentsceneindex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextsceneindex);
    }
}
