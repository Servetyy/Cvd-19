using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenüController : MonoBehaviour
{
    public void exitGame()
    {
        Application.Quit();
    }
    public void startGame()
    {
        SceneManager.LoadScene("Levels");
    }
    public void level1()
    {
        SceneManager.LoadScene("1");
    }
    public void level2()
    {
        SceneManager.LoadScene("2");
    }
    public void level3()
    {
        SceneManager.LoadScene("3");
    }
    public void level4()
    {
        SceneManager.LoadScene("4");
    }
    public void level5()
    {
        SceneManager.LoadScene("5");
    }
    public void level6()
    {
        SceneManager.LoadScene("6");
    }
    public void level7()
    {
        SceneManager.LoadScene("7");
    }
    public void level8()
    {
        SceneManager.LoadScene("8");
    }
    public void level9()
    {
        SceneManager.LoadScene("9");
    }
    public void level10()
    {
        SceneManager.LoadScene("10");
    }
    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void levels()
    {
        SceneManager.LoadScene("Levels");
    }    
}
