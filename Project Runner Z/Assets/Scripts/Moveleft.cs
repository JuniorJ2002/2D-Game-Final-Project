using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveleft : MonoBehaviour
{
    // Global Variables
    public float speed = 30.0f;
    public PlayerController playerController;
    private float leftBound = -15.0f;


    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("HeroKnight").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (playerController)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }


}
