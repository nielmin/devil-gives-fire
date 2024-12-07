using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("Underground");
    }

    public void Options() {
        SceneManager.LoadScene("Options");
    }

    public void ExitGame() {
        Application.Quit();
    }
}
