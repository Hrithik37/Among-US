using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("vertical",Input.GetAxis("Vertical"));
         //transform.Translate(1f*Time.deltaTime,0f,0f)
        // if(Input.GetKeyDown(KeyCode.W))
        // {
        //    
        //     anim.Play("forward");
        // }
    }
}
