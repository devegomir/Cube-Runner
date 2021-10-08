using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEndend = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public Text helpText;
    
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEndend == false)
        {
            Debug.Log("Game Over!");
            gameHasEndend = true;
            Invoke("Restart", restartDelay);
            
        }
        
    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Start()
    {
        Invoke("changeText", 2);
        Invoke("changeTextTwo", 4);
        Invoke("deleteText", 6);
    }

    private void changeText()
    {
         helpText.text = "Press A/D to move";
    }
    private void changeTextTwo()
    {
        helpText.text = "Press R for slowmow (2 Charges)";
    }

    private void deleteText()
    {
        helpText.text = " ";
    }


}
