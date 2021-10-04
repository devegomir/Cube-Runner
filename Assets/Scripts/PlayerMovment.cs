using System.IO;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpingForce = 100f;

    private bool rightMovment;
    private bool leftMovment;

    private bool jumping;

    private void Update()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            leftMovment = true;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            rightMovment = true;
        }
        if (Input.GetButton("Jump"))
        {
            jumping = true;
        }
        
    }


    // Update is called once per Phys.frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //Movment
        if (rightMovment == true)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rightMovment = false;
        }
        if (leftMovment == true)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            leftMovment = false;
        }
        if (jumping == true && transform.position.y < 1.01f && transform.position.y > 0.99f)
        {
            rb.AddForce(0, jumpingForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            jumping = false;
        }
           

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        
    }

    

    

}