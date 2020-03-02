using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorCapsule : MonoBehaviour
{

    public Transform locationZ;

    float a;
    float b;
    float c;
    // Start is called before the first frame update
    void Start()
    {

        locationZ = gameObject.GetComponent<Transform>();


    }

    // Update is called once per frame
    void Update()
    {
        //Getting ready to write info    //Getting ready to read info

        //locationZ.position = locationZ.position + new Vector3(0, 0, 0.5f);

        locationZ.position = locationZ.position + Vector3.forward * .1f;
    }
}