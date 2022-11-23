using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float jumpingPower;
    private float lungPower;
    public float y = .04f;
    public float x = .01f;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(IsGrounded() && rb.velocity.y < 0)
        {
            rb.velocity = new Vector2(0, 0);
        }

        if (Input.GetButton("Jump") && IsGrounded())
        {
            jumpingPower += y;
            lungPower += x;
        }

        if (Input.GetButtonUp("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(jumpingPower, jumpingPower);
            jumpingPower = 0;
            lungPower = 0;
        }

    }


    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }


}
