using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //References
    public Rigidbody rb;

    // Movement Forces
    public int forwardForce = 1500;
    public int sidewaysForce = 500;
    public int jumpForce = 17500;
    public float jumpCooldown = 3f;
    private float jumpTimer = 3f;

    //Inputs
    private bool moveLeft;
    private bool moveRight;
    private bool moveJump;


    // Update is called once per frame
    private void Update()
    {
        moveLeft = (Input.GetKey("a") || Input.GetKey("left"));
        moveRight = (Input.GetKey("d") || Input.GetKey("right"));
        moveJump = (Input.GetKey("space") || Input.GetKey("up"));
        jumpTimer += Time.deltaTime;
    }


    void FixedUpdate ()
    {
        // Forwards Propullsion
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);


        // Movement Controls
        if (moveLeft)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (moveRight)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (moveJump && jumpTimer >= jumpCooldown)
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
            jumpTimer = 0;
        }

        // Fall Check

        if(transform.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


        //// Rotation check

        //Quaternion hello = new Quaternion(1f, 1f, 1f, 1f);
        //transform.rotation = hello;
    }
}


