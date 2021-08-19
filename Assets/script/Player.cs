using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    private Animator anim=null;
    private Rigidbody2D rb=null;
    private bool jump;
    void Start()
    {
        anim=GetComponent<Animator>();
        rb=GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalKey=Input.GetAxis("Horizontal");
        float xSpeed=0.0f;
        if(horizontalKey>0)
        {
            transform.localScale=new Vector3(1,1,1);
            anim.SetBool("run",true);
            xSpeed=speed;
        }else if(horizontalKey<0)
        {
            transform.localScale=new Vector3(-1,1,1);
            anim.SetBool("run",true);
            xSpeed=-speed;
        }else
        {
            anim.SetBool("run",false);
            xSpeed=0.0f;
        }
        rb.velocity=new Vector2(xSpeed,rb.velocity.y);
        if (Input.GetKeyDown("space") && !jump)
        {
            rb.AddForce(Vector2.up*flap);
            jump = true;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jump = false;
        }
    }
    
}


