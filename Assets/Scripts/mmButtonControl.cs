using UnityEngine;
using UnityEngine.SceneManagement;

public class mmButtonControl : MonoBehaviour {

    public GameObject levelSelect;
    public GameObject howToPlay;

    public void LevelSelect(bool Open)
    {
        levelSelect.SetActive(Open);
    }

    public void HowToPlay(bool Open)
    {
        Debug.Log("test");
        howToPlay.SetActive(Open);
    }

    public void OpenLevel(int buildNumber)
    {
        SceneManager.LoadScene(buildNumber);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
