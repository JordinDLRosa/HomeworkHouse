using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChimneyPrefab : MonoBehaviour
{
    public GameObject chimneyPrefabExample;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 2; i++)
        {
            for (int p = 7; p < 9; p++)
                Instantiate(chimneyPrefabExample, new Vector3(i, p, 0), Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
