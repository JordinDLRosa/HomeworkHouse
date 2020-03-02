using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPrefab : MonoBehaviour
{
    public GameObject doorPrefabExample;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 3; i < 4; i++)
        {
            for (int p = 0; p < 2; p++)
                Instantiate(doorPrefabExample, new Vector3(i, p, 0), Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
