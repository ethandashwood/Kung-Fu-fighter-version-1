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
        print("anim=" + anim);

    }

   
    void Update()
    {
        if (isMoving == false)
        {

            anim.SetBool("isIdle", true);
        }

        print("left=" + moveLeft + "  right=" + moveRight);
    }
    void LateUpdate()
    {


        isMoving = false;

        /* while (isMoving == false)
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isCrouch", false);
            anim.SetBool("isWalking", true);
        }*/

        if (moveLeft)
        {

            pSpeed = -6.0f;
            transform.position += new Vector3(pSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0f, 0);
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
            anim.SetBool("isPunch", false);
            anim.SetBool("isCrouch", false);

            isMoving = true;


        }

        if (moveRight)
        {
            pSpeed = 6.0f;
            transform.position += new Vector3(pSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 180f, 0);
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
            anim.SetBool("isPunch", false);
            anim.SetBool("isCrouch", false);

            isMoving = true;

        }

        if (pCrouch)
        {
            pSpeed = 0.0f;
            anim.SetBool("isCrouch", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isPunch", false);

        }


        if (pPunch == true)
        {


            StartCoroutine(PunchWait());


        }


    }

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

    IEnumerator PunchWait()
    {
        anim.SetBool("isPunch", true);

            yield return new WaitForSeconds(2);

        anim.SetBool("isPunch", false);
    }

}
