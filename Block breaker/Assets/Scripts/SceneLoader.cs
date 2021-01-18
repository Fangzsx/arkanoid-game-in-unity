using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{


    
    public void LoadNextScene()
    {
        //index of currentIndex Scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);

    }

    public void LoadStartScreen(){
        SceneManager.LoadScene(0);
        FindObjectOfType<GameSession>().DestroyGameStatus();
    }

    public void LoadHowToPlayScreen(){
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
