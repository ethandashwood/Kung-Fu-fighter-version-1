using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : MonoBehaviour
{
    //Movement variables
    public float pSpeed;
    private Rigidbody2D rb;
    


    //Control variables

    static bool moveLeft;
    static bool moveRight;
    static bool pJump;
    public static bool pPunch;


    //Other
    public GameObject enemy;

    void OnTriggerEnter2D(Collider2D enemy)
    {

    }



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pSpeed = 0.0f;

        pPunch = false;
        moveRight = false;
        moveLeft = false;
    }

   

    void Update()
    {

        if (moveLeft)
        {
            pSpeed = -6.0f;
            transform.position += new Vector3(pSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0f, 0);
        }

        if (moveRight)
        {
            pSpeed = 6.0f;
            transform.position += new Vector3(pSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 180f, 0);
        }


    }


    //Movement Methods
    public void StopMove()
    {
        moveRight = false;
        moveLeft = false;
        pSpeed = 0.0f;
        print("stop!");
    }


    public void IsLeft()
    {    
        moveLeft = true;
    }

    public void IsRight()
    {
        moveRight = true;
    }

    public void IsPunch()
    {
        pPunch = true;
    }




}
