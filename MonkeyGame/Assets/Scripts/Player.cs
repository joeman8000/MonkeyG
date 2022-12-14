using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float jumpingPower;
    private float lungPower;
    public float y = .04f;
    public float x = .12f;
    public float wind = .05f;
    public Animator monkey;
    public ParticleSystem jumppart;
    public GameObject jumpobj;
    public Text holde;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(!IsGrounded())
        {
        rb.velocity = new Vector2(rb.velocity.x - (wind * 2), rb.velocity.y);
        monkey.SetBool("InAir", true);
        }
        if(IsGrounded()){
            monkey.SetBool("InAir", false);
        }
        if(IsGrounded() && rb.velocity.y < 0)
        {
            rb.velocity = new Vector2(0, 0);
        }

        if (Input.GetButton("Jump") && IsGrounded())
        {
            jumpingPower += y;
            lungPower += x;
            monkey.SetBool("Charging", true);
            jumpobj.transform.position = new Vector2(transform.position.x, transform.position.y);
        }

        if (Input.GetButtonUp("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(jumpingPower*3, 10);
            jumpingPower = 0;
            lungPower = 0;
            monkey.SetBool("Charging", false);
            jumppart.Play();
            Destroy(holde);
        }
        if(transform.position.y < -5)
        {
            SceneManager.LoadScene(sceneBuildIndex: 1);
        }

    }


    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }


}
