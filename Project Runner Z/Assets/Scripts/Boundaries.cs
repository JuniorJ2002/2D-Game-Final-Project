using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    public float xRange = 20.0f;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Left Boundaries
        if (transform.position.x < -xRange)
        {
            //Setting up our Boundaries
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //Right Boundaries
        if (transform.position.x > xRange)
        {
            //Setting up our Boundaries
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
