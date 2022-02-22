using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;

    public float camSpeed = 0.2f;
    public Vector3 offset;



    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
