using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charStart : MonoBehaviour
{

    public GameObject enemyPre;


    void Start()
    {

        Instantiate(enemyPre, new Vector3(-95, 3, 0), Quaternion.identity);

    }


    void Update()
    {
        
    }
}
