using UnityEngine;

public class move : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 1000f;
    public bool jump = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")) {
            jump = true;
        } else {
            jump = false;
        }

    }
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
        if (jump) {
            rb.AddForce(0, sidewaysForce * Time.deltaTime, 0);
        }
        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
