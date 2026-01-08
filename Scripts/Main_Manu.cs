using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour
{
   public void playGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void mainMenu() {
        SceneManager.LoadScene("Maib Manu");
    }

    public void settingMenu()
    {
        SceneManager.LoadScene("Setting Manu");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
