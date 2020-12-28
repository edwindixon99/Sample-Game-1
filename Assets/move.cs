using UnityEngine;

public class move : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 100f;
    public float jumpForce = 1f;
    public bool onGround = true;

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
        
        

        if (Input.GetKey("w")) {

            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s")) {

            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) {

            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d")) {

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("space") && onGround) {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.Impulse);
            onGround = false;
        }
        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
        Debug.Log(GameObject.Find("Cube").transform.position);
    }

    //When a moving cube collides with a obect it can jump again
    void OnCollisionEnter(Collision collision) { 
        // if (collision.gameObject.name == "Ground") {
        Debug.Log("landed!");
        onGround = true;
        // }
    }
}
