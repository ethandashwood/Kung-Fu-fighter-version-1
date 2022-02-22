using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    public static bool inRange;
    public GameObject Enemy;

    void Start()
    {
        inRange = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        inRange = true;
        Debug.Log("wow");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        inRange = false;
        Debug.Log("out of range");
    }


    void Update()
    {


        if (Input.GetKey("k") && inRange == true)
        {
            Destroy(GameObject.Find("Enemy"));
            Debug.Log("enemy is being attacked!");
        }
    }
}
