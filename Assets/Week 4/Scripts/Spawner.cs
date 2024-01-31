using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float timerValue;
    float timerTarget;
    public GameObject planeprefab;
    // Start is called before the first frame update
    void Start()
    {
        timerValue = 0;
        timerTarget = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerValue <= 0)
        {
            //Debug.Log("timer reset " + timerValue);
           
            timerTarget = Random.Range(1, 5);
            timerValue = timerTarget;
            Instantiate(planeprefab);
        } else
        {
            //Debug.Log("timer ticked "+ timerValue);
            timerValue -= Time.deltaTime;
            
        }
        

    }
}
