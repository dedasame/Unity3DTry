using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    //Oyunu Kapatir
    public void ExitGame()
    {
        Application.Quit(); 
    }

    //Ba�lang�� ekran�na geri atar
    public void StartAgain()
    {
        SceneManager.LoadScene(0);
    }
}
