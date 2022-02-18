using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public Animator anim;

    public float moveSpeed;

    public float x, y;

    private bool isWalking;

    private Vector3 moveDir;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        if (x != 0 || y != 0)
        {
            anim.SetFloat("X", x);
            anim.SetFloat("Y", y);

            if (!isWalking)
            {
                isWalking = true;
                anim.SetBool("IsMoving", isWalking);
            }
        }
        else
        {
            if (isWalking)
            {
                isWalking = false;
                anim.SetBool("IsMoving", isWalking);
                StopMoving();
            }
        }

        if (y > 0)
        {
            if (x != 0)
            {
                y = y + 0.5f;
            }else
            {
                y = 0;
            }
            
        }else
        {
            if(x != 0)
            {
                y = y + 0.5f;
            }
        }

        //print("x: " + x);
        //print("y: " + y);

        moveDir = new Vector3(x, y).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = moveDir * moveSpeed * Time.deltaTime;
    }

    private void StopMoving()
    {
        rb.velocity = Vector3.zero;
    }
}

