using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Animator animator;
    Camera viewCam;


    private Vector2 moveDir;

     void Start()
    {
        viewCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        inputs();


        Vector2 mousePos = viewCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));

        moveDir = mousePos - rb.position;
        //Vector3 mousePos = viewCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
        //transform.LookAt(mousePos + Vector3.up * transform.position.y);
        //var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //transform.rotation = Quaternion.LookRotation(Vector3.forward, (mouseWorldPosition - transform.position).normalized);
        //
    }

    private void FixedUpdate()
    {
        //physics calc
        move();
    }

    void inputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", moveDir.x);
        animator.SetFloat("Vertical", moveDir.y);
        animator.SetFloat("Speed", moveDir.sqrMagnitude);



        moveDir = new Vector2(moveX, moveY).normalized;


    }

     void move()
    {
        rb.velocity = new Vector2(moveDir.x * speed, moveDir.y * speed);
    }
}
