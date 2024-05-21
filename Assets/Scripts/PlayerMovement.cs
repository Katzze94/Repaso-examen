using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rBody;

    private float  inputHorizontal;

    public SpriteRenderer sprite;

    public Vector3 newPosition = new Vector3(50, 5, 0);

    public GroundSensor sensor;

    public float jumpForce = 10;

    public float movementSpeed = 5;

    public bool jump = false;

    public Animator animator;

   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");

        if(Input.GetButtonDown("Jump") && sensor.isGrounded == true)
        {
            rBody.AddForce(new Vector2(0,1) * jumpForce, ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true);
            
        }
        if(inputHorizontal < 0)
        {
            sprite.flipX = true;
            animator.SetBool("IsRunning", true);
          
        }
        else if(inputHorizontal > 0)
        {
            sprite.flipX = false;
            animator.SetBool("IsRunning", true);
           
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }
        
        
    }

    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        
       
    }


    void FixedUpdate()
    {
        rBody.velocity = new Vector2(inputHorizontal * movementSpeed, rBody.velocity.y);
    }



}
