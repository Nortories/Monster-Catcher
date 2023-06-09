using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 7f;
    private Rigidbody2D rb;
    private Vector2 movementDirection;

    void Start()
    {
        GameObject playerpos = GameObject.Find("PlayerPosSave");
        // sets player postition to empty game object postion on start.
        this.transform.position = playerpos.transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GameObject playerpos = GameObject.Find("PlayerPosSave");
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        // Update empty game object that wont get destoryed on scene change, with current player position
        playerpos.transform.position = this.transform.position;

    }

    void FixedUpdate() {
        rb.velocity = movementDirection * movementSpeed;
    }
}
