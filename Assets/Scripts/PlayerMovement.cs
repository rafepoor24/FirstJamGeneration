using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private bool Grunded;
    private Animator anim;
    private float dirX;
    [SerializeField] private float jumpforce=14f;
    [SerializeField]  private float moveSpeed=7f;


    private enum MovementState {Idle,running,Jump,Falling }




    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        sprite=GetComponent<SpriteRenderer>();  
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX*moveSpeed, rb.velocity.y);

        /*if (Input.nGetButtonDow("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 14f);
        }*/

       /* Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);

        if (Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
        {
            Grunded = true;
        }
        else Grunded = false;
       */

       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }

        updateAnimationUpdate();
       
    }
  
    void jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpforce);
    }

    private void updateAnimationUpdate()
    {
        MovementState state;

        if (dirX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.running;
            // cambia la orientacion de player, x=-1, en el sprite rendered el flip x se activa
            sprite.flipX = true;
        }
        else { 
        state = MovementState.Idle;
    }

        if (rb.velocity.y > .1f)
        {
            state=MovementState.Jump;
        }
        else if(rb.velocity.y < -.1f)
        {
            state = MovementState.Falling;
        }
        anim.SetInteger("state",(int) state);
    }

}
   
