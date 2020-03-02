using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    //public Vector3 directionThatIWantTransformToMoveEveryUpdate;
    public Transform location;
    // bool Life;
    bool falseMoveRightTrueMoveLeft;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {

        location = gameObject.GetComponent<Transform>();



    }

    // Update is called once per frame
     void Update()
     {
        /*
         if (transform.position.x >= 10)
         {
             falseMoveRightTrueMoveLeft = true;
         }
         else if (transform.position.x <= -10)
         {
             falseMoveRightTrueMoveLeft = false;
         }

         if (falseMoveRightTrueMoveLeft == false)
         {
             transform.position = transform.position + Vector3.right * .1f;
         }
         else
         {
             transform.position = transform.position - new Vector3(1, 1, 0)  Normalize * .1f;
         }
         */
        //Vector3.Normalize returns a Vector 3 to the same direction to the length of 1
        //Vector3.Normalize(new Vector3(1,1,0))

        /*
        if (transform.position.x >= 10)
        {
            location.position = location.position + new Vector3(-0.05f, 0, 0);
        }

        else if (location.position.x <= -10)
        {
            location.position = location.position + new Vector3(0.05f, 0, 0);
        }
        */
        //Getting ready to write info    //Getting ready to read info

        //transform.position = transform.position + directionThatIWantTransformToMoveEveryUpdate;
        if (transform.position.x >= 10)
            falseMoveRightTrueMoveLeft = true;
        else if (transform.position.x <= -10)
            falseMoveRightTrueMoveLeft = false;

        if (falseMoveRightTrueMoveLeft == false)
        {
            transform.position = transform.position + Vector3.Normalize(new Vector3(1, 0, 0)) * Time.deltaTime * speed;
        }
        else
        {
            transform.position = transform.position - Vector3.right * Time.deltaTime * speed;
        }

}
    }

