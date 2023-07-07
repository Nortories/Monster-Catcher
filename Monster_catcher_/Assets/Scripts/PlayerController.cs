using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 7f;
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    private Animator animator;


    void Start()
    {
        GameObject playerpos = GameObject.Find("PlayerPosSave");
        // sets player postition to empty game object postion on start.
        this.transform.position = playerpos.transform.position;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        GameObject playerpos = GameObject.Find("PlayerPosSave");
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        // Update empty game object that wont get destoryed on scene change, with current player position
        playerpos.transform.position = this.transform.position;


        if (Input.GetKey(KeyCode.A) && rb.velocity.magnitude > 1)
            {
                animator.SetInteger("Direction", 3);
            }
            else if (Input.GetKey(KeyCode.D) && rb.velocity.magnitude > 1)
            {
                animator.SetInteger("Direction", 2);
            }

            if (Input.GetKey(KeyCode.W) && rb.velocity.magnitude > 1)
            {
                animator.SetInteger("Direction", 1);
            }
            else if (Input.GetKey(KeyCode.S) && rb.velocity.magnitude > 1)
            {
                animator.SetInteger("Direction", 0);
            }

            if (rb.velocity.magnitude < 1)
            {
                animator.SetBool("IsMoving", false);
            }
            else
            {
                animator.SetBool("IsMoving", true);
            }
            // Debug.Log(rb.velocity.magnitude);
    }

    void FixedUpdate() {
        rb.velocity = movementDirection * movementSpeed;
    }
}
