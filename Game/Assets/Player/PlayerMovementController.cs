using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
   public float runSpeed;
   public CharacterController controller;

   public float gravity = -9.81f;
   Vector3 velocity ;
   public Transform groundcheck;
   public float groundDistance = 0.4f;
   public LayerMask groundMask;
   bool isGrounded;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundcheck.position,groundDistance,groundMask);
        if(isGrounded&& velocity.y<0){
            velocity.y=-2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move= transform.right*x + transform.forward*z;
        //Vector3 move= transform.forward*z;
        controller.Move(move*runSpeed*Time.deltaTime);
        animator.SetFloat("isRunning",Mathf.Abs(z));
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);

    }
}
