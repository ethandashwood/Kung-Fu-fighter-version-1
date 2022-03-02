using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    public bool punched;
    private float Speed;
    public float enSpeed;
    public bool inRange;

    public float dSpeed;
    public GameObject target; 

    void Start()
    {
        punched = false;
        enSpeed = Speed;
        inRange = false;
        dSpeed = 0.0f;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        Debug.Log("Enemy is stopping");
        enSpeed = 0.0f;
        inRange = true;
    }

    void OnTriggerExit2D(Collider2D target)
    {
        Debug.Log("Enemys is moving again");
        enSpeed = Speed;
        inRange = false;
    }



    void Update()
    {
        if (inRange == false)
        {
            transform.position += new Vector3(enSpeed * Time.deltaTime, 0, 0);
        }

        if (inRange == true && punched == true)
        {
            dSpeed = -4.0f;
            enSpeed = 0.0f;
            Debug.Log("HELP");
            transform.position += new Vector3(enSpeed, dSpeed * Time.deltaTime, 0);
        }

    }



    public void Punch()
    {
        punched = true;
    }

}