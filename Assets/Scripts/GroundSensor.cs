using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{

    public bool isGrounded;
    PlayerMovement playerScript;
    public Animator animator;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
     {
        playerScript =GetComponentInParent<PlayerMovement>();
        animator = GetComponentInParent<Animator>();
        
     }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        isGrounded = true;
        animator.SetBool("IsJumping", false);
        
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        isGrounded = false;

    }
}
