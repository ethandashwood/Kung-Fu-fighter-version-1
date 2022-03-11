using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    public static bool punched;
    public float Speed;
    private float enSpeed;
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

    void OnTriggerEnter2D(Collider2D other)
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
        punched = false;

        transform.position += new Vector3(enSpeed * Time.deltaTime, 0, 0);       
       
    }



    public void Punch()
    {
        punched = true;
        Debug.Log("punch is starting");
    }

}