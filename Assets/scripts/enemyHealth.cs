using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    private float enHealth;

    void Start()
    {
        enHealth = 100f;
    }

    void Update()
    {
        if (enemyBehaviour.punched)
        {
            enHealth -= 30;
            Debug.Log(enHealth);

            if (enHealth < 0)
            {
                Debug.Log("dead");
                Destroy(gameObject);
            }
        }
    }
}
