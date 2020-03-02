using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorSphere : MonoBehaviour
{
    public Transform locationY;

    
    // Start is called before the first frame update
    void Start()
    {
        locationY = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        locationY.position = locationY.position + new Vector3(0, .05f, 0);
    }
}
