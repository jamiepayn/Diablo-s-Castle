using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

   float horizontalMove = 0f;
    public Animator animator;
   public float runSpeed = 40f;
   bool jump = false;

    // Update is called once per frame
    void Update()
    {

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

       if (Input.GetButtonDown("Jump"))
       {
           animator.SetBool("IsJumping", true);
           jump = true;
            
       }
        
    }

    public void OnLanding ()
    {

        animator.SetBool("IsJumping", false);
    }

    public void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
        
    }
}
