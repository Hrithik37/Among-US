using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{

    public Transform playerTransform;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position=playerTransform.position+offset;
        transform.rotation=playerTransform.rotation;
    }
}
