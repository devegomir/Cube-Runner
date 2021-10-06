using UnityEngine;

public class StoneTrapTrigger : MonoBehaviour
{
    //Triggers Objects to Fall from the sky
    public GameObject fallingDownEnable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            fallingDownEnable.SetActive(true);
        }
    }

}
    