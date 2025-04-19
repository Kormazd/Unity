using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Intro"); 
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitter le jeu");
    }
}