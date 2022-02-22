using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : MonoBehaviour
{
    //Movement variables
    private float pSpeed;
    private Rigidbody2D rb;


    //Control variables
    static bool pCrouch;
    static bool moveLeft;
    static bool moveRight;
    static bool pJump;
    static bool isMoving;
    static bool pPunch;

    //Other
    private Animator anim;
    public GameObject enemy;


    void OnTriggerEnter2D(Collider2D enemy)
    {
        StopMove();
    }



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pSpeed = 0.0f;

        isMoving = false;
        moveRight = false;
        moveLeft = false;
        pCrouch = false;
        pPunch = false;

        anim = GetComponent<Animator>();

    }

   
    void Update()
    {



        if (moveLeft)
        {

            pSpeed = -6.0f;
            transform.position += new Vector3(pSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0f, 0);
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);

            isMoving = true;


        }

        if (moveRight)
        {
            pSpeed = 6.0f;
            transform.position += new Vector3(pSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 180f, 0);
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);

            isMoving = true;

        }

        if (pCrouch)
        {
            pSpeed = 0.0f;
            anim.SetBool("isCrouch", true);

        }

        if (isMoving == true)
        {
            anim.SetBool("isCrouch", false);
        }

        if (isMoving == false && pPunch == true)
        {

            anim.SetBool("isPunch", true);

            if (anim.GetCurrentAnimatorStateInfo(0).IsName("playerpunch") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.5f) ;
            {
                anim.SetBool("isPunch", false);
                Debug.Log("punch anim finished");
            }

        }

    }

    public void StopMove()
    {
        moveRight = false;
        moveLeft = false;
        pSpeed = 0.0f;
        anim.SetBool("isWalking", false);
        anim.SetBool("isIdle", true);
        anim.SetBool("isCrouch", false);
        isMoving = false;
    }


    public void IsLeft()
    {
        
        moveLeft = true;

    }

    public void IsCrouch()
    {
        pCrouch = true;
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
