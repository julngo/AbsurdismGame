using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActive().buildIndex +1);
    }

    public void QuitGame()
    {
        Debug.Log("You've Quit the Game");
        Application.Quit();
    }
}
