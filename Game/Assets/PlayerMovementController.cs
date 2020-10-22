﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float runSpeed;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input= new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        Vector2 inputDir=input.normalized;

        if(inputDir!=Vector2.zero)
        {
            transform.eulerAngles=Vector3.up*Mathf.Atan2(inputDir.x,inputDir.y)*Mathf.Rad2Deg;
        }

        float speed= runSpeed*inputDir.magnitude;
        transform.Translate(transform.forward*speed*Time.deltaTime , Space.World);

        animator.SetFloat("isRunning",inputDir.magnitude);
    }
}
