using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponspawner : MonoBehaviour
{
    public GameObject weaponprefab;
    public Transform spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void createweapon()
    {
        Instantiate(weaponprefab, spawner.position, spawner.rotation);
    }
}
