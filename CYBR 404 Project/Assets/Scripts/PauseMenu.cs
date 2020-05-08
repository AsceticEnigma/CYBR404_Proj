using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject optionsMenuUI;
    string mainMenu = "mainMenu";

    void Update()
    {
        if (!gameIsPaused) {
            if (Input.GetKeyDown(KeyCode.Escape)) {

                PauseGame();
            }
        }
    }
    public void ResumeGame() {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    private void PauseGame() {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void SetGamePaused() {
        
        gameIsPaused = true;
    }

    public void LoadOptionsMenu() {

        pauseMenuUI.SetActive(false);
        optionsMenuUI.SetActive(true);
    }

    public void QuitToMainMenu() {

        SceneManager.LoadScene(mainMenu);
    }
}
