using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

    // Use this for initialization
    public void PlayGame() {
        SceneManager.LoadScene("angry");
    }

    public void LoadAddition()
    {
        SceneManager.LoadScene("additionOne");
    }

    public void LoadSubtraction()
    {
        SceneManager.LoadScene("subtractionOne");
    }

    public void LoadMultiplicationAndDivision()
    {
        SceneManager.LoadScene("multDivOne");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

   

}
