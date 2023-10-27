using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
   
    public void GoGamesMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void Games(int games)
    {
        SceneManager.LoadScene(games);
    }
    public void Quit()
    {
        Application.Quit();
    }

}
