using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowPrefab : MonoBehaviour
{
    public GameObject windowPrefabExample;
    // Start is called before the first frame update
    void Start()
    {
        //1st Window
        for (int i = 2; i < 3; i++)
        {
            for (int p = 3; p < 4; p++)
                Instantiate(windowPrefabExample, new Vector3(i, p, 0), Quaternion.identity);

        }
        //2nd Window
        for (int k = 4; k < 5; k++)
        {
            for (int q = 3; q < 4; q++)
                Instantiate(windowPrefabExample, new Vector3(k, q , 0), Quaternion.identity);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
