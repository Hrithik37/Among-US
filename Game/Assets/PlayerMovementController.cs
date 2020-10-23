using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
   public float runSpeed;
   public CharacterController controller;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       // float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
       // Vector3 move= transform.right*x + transform.forward*z;
        Vector3 move= transform.forward*z;
        controller.Move(move*runSpeed*Time.deltaTime);
        animator.SetFloat("isRunning",Mathf.Abs(z));  
    }
}
