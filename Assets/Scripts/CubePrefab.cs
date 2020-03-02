using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePrefab : MonoBehaviour
{
    public GameObject cubePrefabExample;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 6; i++)
        {
            for(int p = 0; p <5; p++)
            Instantiate(cubePrefabExample, new Vector3(i,p,0), Quaternion.identity);
               
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
