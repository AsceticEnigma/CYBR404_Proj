using UnityEngine;
using UnityEngine.SceneManagement;

public class creditsButton : MonoBehaviour
{
    string mainMenu = "mainMenu";

    public void loadMainMenu() {

        SceneManager.LoadScene(mainMenu);
    }
}
