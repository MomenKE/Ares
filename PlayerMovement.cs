using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    public float forwardForce = 200f;
    public float sidewayForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

    }
}
