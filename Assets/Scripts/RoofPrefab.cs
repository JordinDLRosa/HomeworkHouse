using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofPrefab : MonoBehaviour
{
    public GameObject roofPrefabExample;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = -1; i < 7; i++)
        {
            for (int p = 5; p < 7; p++)
                Instantiate(roofPrefabExample, new Vector3(i, p, 0), Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
