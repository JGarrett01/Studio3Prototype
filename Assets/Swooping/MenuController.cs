using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {


    /*public void StartGame()
    {
        SceneManager.LoadScene("");
    }*/

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void StartSwoopGame()
    {
        SceneManager.LoadScene(1);
    }

    public void StartRaceGame()
    {
        SceneManager.LoadScene(2);
    }

    public void StartSubGame()
    {
        SceneManager.LoadScene(3);
    }

    public void StartTapGame()
    {
        SceneManager.LoadScene(4);
    }
}
