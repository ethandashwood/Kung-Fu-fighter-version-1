using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{

    public float Speed;
    private float enSpeed;
    public bool inRange;

    public GameObject target; 

    void Start()
    {

        enSpeed = Speed;
        inRange = false;
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

        transform.position += new Vector3(enSpeed * Time.deltaTime, 0, 0);
    }


}