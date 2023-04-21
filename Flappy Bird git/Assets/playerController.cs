using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float force;
    public float jumpDelay;
    public float jumpTimer;
    private bool space;
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
        
    }

    void Movement()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jumpTimer >= jumpDelay)
        {
            Debug.Log("DUPA");
            rb.AddForce(Vector2.up * force * Time.deltaTime, ForceMode2D.Impulse);
            previusY= transform.position.y;
            jumpTimer = 0;
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
