using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class SceneSwitcher : MonoBehaviour
{
    public void MainMenu()
    {
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void HandSelection()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Learn()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void Game()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void Settings()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void Devices()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    private string GetDebuggerDisplay()
    {
        return ToString();
    }

}
