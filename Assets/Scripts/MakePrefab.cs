using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePrefab : MonoBehaviour
{
    //Prefab is a template for a Game Object
    public GameObject spherePrefabExampleThing;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            Instantiate(spherePrefabExampleThing,
                new Vector3
                (Random.Range(-10.0f, 10.0f),
                Random.Range(-8.0f, 8.0f), 
                Random.Range(-5.0f, 5.0f)),
                Quaternion.identity);
        }
        

        /*
        //Spawns more spheres
        Instantiate(spherePrefabExampleThing, 
            new Vector3(10,10,20), Quaternion.identity);
        Instantiate(spherePrefabExampleThing,
            new Vector3(5,5,10), Quaternion.identity);
        */
    }
    void Update()
    {
        
    }

}