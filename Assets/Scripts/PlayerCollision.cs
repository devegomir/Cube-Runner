using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovment movment;
    public Rigidbody playerBody;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movment.enabled = false;
            playerBody.freezeRotation = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
