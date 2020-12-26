 using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        Debug.Log("You Won!"); 
        completeLevelUI.SetActive(true);
    }
    public void EndGame ()
    {
        if (!gameHasEnded) {
            gameHasEnded = true;
            Debug.Log("game over");
            Invoke("Restart", 1f);
        }
        
    }

    void Restart () 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
