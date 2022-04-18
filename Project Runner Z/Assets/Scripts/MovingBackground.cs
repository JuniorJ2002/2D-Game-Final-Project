using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovingBackground : MonoBehaviour
{
    //variable
    public Vector3 startPos;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x / 3.4f;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}