using UnityEngine;

public class move : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 100f;
    public float jumpForce = 1000f;
    public float longJumpForce = 3000f;
    public float nlongJumpForce = 1000f;
    public bool onGround = true;
    public bool longJump;
    public float zForce;
    public float xForce;


    // Update is called once per frame
    // void Update()
    // {
    //     if () {
    //         jump = true;
    //     } else {
    //         jump = false;
    //     }

    // }
    void FixedUpdate()
    {
        
        
        zForce = 0;
        xForce = 0;

        
        if (Input.GetKey("w")) {

            zForce = 1;
            // rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s")) {

            zForce = -1;
            // rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) {

            xForce = -1;
            // rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d")) {

            xForce = 1;
            // rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("space") && onGround) {
            if (longJump) {
                jumpForce = longJumpForce;
            } else {
                jumpForce = nlongJumpForce;
            }
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.Impulse);
            onGround = false;
        }

        rb.AddForce(xForce * sidewaysForce * Time.deltaTime, 0, zForce * forwardForce * Time.deltaTime, ForceMode.VelocityChange);


        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }

    //When a moving cube collides with a obect it can jump again
    void OnCollisionEnter(Collision collision) { 
        // if (collision.gameObject.name == "Ground") {
        Debug.Log("landed!");
        onGround = true;
        // }
    }

    
}
