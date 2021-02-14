using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{

    [SerializeField] Vector3 xMove;
    [SerializeField] KeyCode xPos;
    [SerializeField] KeyCode xNeg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(xPos) == true)
        {
            GetComponent<Rigidbody>().velocity += xMove;
        }
        if (Input.GetKey(xNeg) == true)
        {
            GetComponent<Rigidbody>().velocity -= xMove;
        }
    }
}
