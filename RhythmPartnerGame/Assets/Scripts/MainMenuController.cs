using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{

    public CanvasGroup OptionPanel;

    public void PlayGame1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayGame2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void PlayGame3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void PlayGame4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void PlayGame5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    public void PlayGame6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    public void PlayGame7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }

    public void PlayGame8()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }

    public void PlayGame9()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }

    public void PlayGame10()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }

    public void PlayGame11()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);
    }

    public void PlayGame12()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 12);
    }

    public void PlayGame13()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 13);
    }

    public void PlayGame14()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 14);
    }

    public void PlayGame15()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 15);
    }

    public void PlayGame16()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 16);
    }

    public void PlayGame17()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 17);
    }

    public void PlayGame18()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 18);
    }

    public void PlayGame19()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 19);
    }

    public void PlayGame20()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 20);
    }

    public void PlayGameB()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

    public void PlayGameB2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }





































    public void QuitGame()
    {
        Application.Quit();
    }

}