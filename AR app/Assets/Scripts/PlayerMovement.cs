using UnityEngine;

public class PlayerMovement : MonoBehaviour
{



    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public Vector3 pos;

    void FixedUpdate()
    {

   

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }


        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }


        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }


        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

        pos = transform.position;

        if (pos[2]>-10.04)
        {
            Debug.Log("hihi");
        }
    }

}