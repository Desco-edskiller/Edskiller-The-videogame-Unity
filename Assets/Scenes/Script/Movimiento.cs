using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    
    public float runSpeed=2;

    public float jumpSpeed = 3;

    Rigidbody2D rb2D;

    public SpriteRenderer SpriteRenderer;

    public Animator animator;


    void Start()
    {
      rb2D = GetComponent<Rigidbody2D>();  
    }

    
    void FixedUpdate()
    {
       if (Input.GetKey("right"))
       {
           rb2D.velocity= new Vector2(runSpeed, rb2D.velocity.y);
           SpriteRenderer.flipX = false;
           animator.SetBool("Correr", true);
           animator.SetBool("Perfil", false);
           animator.SetBool("Saltar", false);
       } 
       else if (Input.GetKey("left"))
       {
           rb2D.velocity= new Vector2(-runSpeed, rb2D.velocity.y);
           SpriteRenderer.flipX = true;
           animator.SetBool("Correr", true);
           animator.SetBool("Perfil", false);
           animator.SetBool("Saltar", false);
       }
       else
       {
           rb2D.velocity=new Vector2(0, rb2D.velocity.y);
           animator.SetBool("Correr", false);
           animator.SetBool("Perfil", true);
           animator.SetBool("Saltar", false);
       }
       if (Input.GetKey("space") && CheckGround.isGrounded)
       {
           rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
           animator.SetBool("Correr", false);
           animator.SetBool("Perfil", false);
           animator.SetBool("Saltar", true);
       }
    }
}
