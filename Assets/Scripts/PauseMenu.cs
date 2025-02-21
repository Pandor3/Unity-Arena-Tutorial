using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuUI;
    private bool isPaused = false;

    void Update()
    {
        // Si le joueur appuie sur Echap, le jeu se mettra en pause
        // Si le jeu est déjà en pause, appuyer sur Echap reprendra la partie
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    void Pause()
     {
        // Ceci affichera le menu de pause
        PauseMenuUI.SetActive(true);
        // Ceci fera en sorte que le temps s'arrête
        Time.timeScale = 0f;
        isPaused = true;
     }

     void Resume()
     {
        // Ceci cachera le menu de pause
        PauseMenuUI.SetActive(false);
        // Ceci fera en sorte que le temps s'écoule à nouveau
        Time.timeScale = 1f;
        isPaused = false;
     }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu Principal");
    }
}
