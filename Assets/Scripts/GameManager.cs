using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    public Text LossUI;
    bool gameHasEnded = false;
    public GameObject CompleteLevelUI;

    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void EndGame(bool Win = false)
    {

        if (!gameHasEnded)
        {
            gameHasEnded = true;

            if (Win)
            {
                Debug.Log("Level Complete!");
                CompleteLevelUI.SetActive(true);
            }
            else
            {
                Debug.Log("Level Failed!");
                Invoke("Restart", restartDelay);
            }
        }
		
		
	}

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
