using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpingForce = 100f;
    public int slowmosLeft = 1;

    private bool rightMovment;
    private bool leftMovment;

    private bool jumping;

    private bool slowmoMode;

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
        if (Input.GetButtonDown("Jump"))
        {
            jumping = true;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            slowmoMode = true;
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
        if (jumping == true && (transform.position.y < 1.01f && transform.position.y > 0.99f))
        {
            rb.AddForce(0, jumpingForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            jumping = false;
        }
           

        if (rb.position.y < -1f || rb.position.x < -9f || rb.position.x > 9f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (slowmoMode == true)
        {
            if (slowmosLeft > 0)
            {
                Time.timeScale = 0.5f;
                Invoke("TimeScaleReset", 1f);
                slowmoMode = false;
                slowmosLeft--;
            }
            
        }

        
    }

    public void TimeScaleReset()
    {
        Time.timeScale = 1f;
    }

    

    

}
