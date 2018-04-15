using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


namespace TMPro.Examples
{
    
    public class SimpleScript : MonoBehaviour
    {

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
}
