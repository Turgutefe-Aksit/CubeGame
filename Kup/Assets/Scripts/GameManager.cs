using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject complateLevelUI;

    public void ComplateLevel()
    {
        complateLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (true)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
