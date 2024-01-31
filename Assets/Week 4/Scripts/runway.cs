using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runway : MonoBehaviour
{
    int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.OverlapPoint(collision.transform.position))
        {
            Debug.Log("triggered");
            collision.GetComponent<Plane>().canland = true;
        }
    }
}
