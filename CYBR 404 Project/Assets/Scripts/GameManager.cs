using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score;
    bool gameHasEnded;
    public float timeDelay = .25f;
    public TMP_Text scoreText;

    public GameObject pauseMenuUI;
    public GameObject optionsMenuUI;
    public GameObject completeMenuUI;
    public GameObject playerDiedUI;
    public GameObject player;
    private PauseMenu pauseMenu;

    private void Start() {

        Time.timeScale = 1f;
        gameHasEnded = false;
        score = 0;
        
        pauseMenuUI.SetActive(false);
        optionsMenuUI.SetActive(false);
        completeMenuUI.SetActive(false);
        playerDiedUI.SetActive(false);

        pauseMenu = FindObjectOfType<PauseMenu>();

    }

    private void Update() {
        scoreText.text = "Score: " + score;
    }

    public void collStarBit() {
        score += 25;
    }

    public void collGem() {
        score += 150;
    }

    public void EndGame() {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            //Restart Game
            Invoke("Restart", timeDelay);
        }
    }

    public void HitDeathBarrier () {

        pauseMenu.SetGamePaused();
        player.SetActive(false);
        playerDiedUI.SetActive(true);
        Invoke("PostDeathPause", timeDelay * 8);
    }

    void PostDeathPause() {

        Time.timeScale = 0f;
    }

    public void Restart() {

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LevelComplete() {

        completeMenuUI.SetActive(true);
    }

    public void LoadNextLevel() {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}