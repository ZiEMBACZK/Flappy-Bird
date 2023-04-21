using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float force;
    public float jumpDelay;
    public float jumpTimer;
    private bool shouldFlap;
    float currentY;
    float previusY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        previusY = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        jumpTimer += Time.deltaTime;
        Movement();
        RotateBird();
    }
    private void FixedUpdate()
    {
        if(shouldFlap)
        {
            rb.velocity= Vector2.zero;
            rb.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
            jumpTimer = 0;
            shouldFlap= false;
        }
    }

    void Movement()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jumpTimer >= jumpDelay)
        {
            shouldFlap= true;
        }
    } 
    private void RotateBird()
    {
        currentY = transform.position.y; 
        if (currentY <= previusY)
        {
            Debug.Log("previus Y");
            previusY = currentY;
        }
    }
}
