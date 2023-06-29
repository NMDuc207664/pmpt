using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static int currentScene = 1;

    public void PlayGame()
    {
        SceneManager.LoadScene("Select level");
    }

<<<<<<< HEAD
=======
    public void CoopGame()
    {
        SceneManager.LoadScene("LobbyTutorial_Done");
    }

>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
    public void SettingsChange()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Setting Menu");
    }

    public void ReturnFromSettings()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void Quitgame()
    {
        Application.Quit();
        Debug.Log("Out of the game");
        //Enable this to reset level
        //PlayerPrefs.SetInt("levelReached", 1);
    }
<<<<<<< HEAD

    public void ToTheTilte()
    {
        SceneManager.LoadScene("Title Scene");
    }
=======
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
}
