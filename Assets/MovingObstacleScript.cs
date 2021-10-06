using UnityEngine;

public class MovingObstacleScript : MonoBehaviour
{
    public Rigidbody physObject;

    public float speed = 200f;

    bool turnAround;

    private void Start()
    {
        physObject.AddForce(speed, 0, 0, ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ChangeDirectionHelper")
        {
            physObject.velocity = Vector3.zero;
            speed *= -1;
            physObject.AddForce(speed, 0, 0, ForceMode.Impulse);
        }
    }

    
}
