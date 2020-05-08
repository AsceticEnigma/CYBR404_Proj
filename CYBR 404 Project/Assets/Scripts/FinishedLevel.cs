using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishedLevel : MonoBehaviour
{
    [SerializeField] public Animator rocketAnimator;
    public GameObject player;

    void Start() {
        rocketAnimator.SetInteger("sceneIndex", SceneManager.GetActiveScene().buildIndex);
    }
    
   void OnTriggerEnter2D(Collider2D other) {

        FindObjectOfType<PauseMenu>().SetGamePaused();
        player.SetActive(false);
        rocketAnimator.SetBool("triggerTakeoff", true);
        FindObjectOfType<GameManager>().LevelComplete();
    }
}
