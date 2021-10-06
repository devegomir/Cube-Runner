using UnityEngine;

public class MovingObstacleScript : MonoBehaviour
{
    //Moves an Obstacle from left to right
    public Transform cubeToTrans;

    // Update is called once per frame
    void Update()
    {
        //CubeMovment();
    }

    void CubeMovment()
    {
        if (cubeToTrans.position.x != 7)
        {
            cubeToTrans.Translate(new Vector3(transform.position.x + 1 * Time.deltaTime, transform.position.y, transform.position.z));
        }
    }
}
