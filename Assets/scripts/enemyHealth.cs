using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    private float enHealth;
    static bool inRange;
    public GameObject target;
    static bool punched;


    void Start()
    {
        punched = false;
        enHealth = 100f;
    }

    void Update()
    {


        if (punched)
        {
            Debug.Log("ouch");

            if (inRange)
            {
                enHealth -= 30;
                Debug.Log(enHealth);
            }

            if (enHealth < 0)
            {
                Debug.Log("dead");
                Destroy(gameObject);
            }
        }

    }

    void OnTriggerEnter2D(Collider2D target)
    {
        Debug.Log("punch in range");
        inRange = true;
    }


    public void Punch()
    {
        punched = true;
        Debug.Log("punch is starting");
    }

}
