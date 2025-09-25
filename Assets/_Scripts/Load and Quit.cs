using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Call this when Start button is pressed
    public void LoadLevelByName(string levelName)
    {
        // Replace "GameScene" with your actual scene name
        SceneManager.LoadScene(levelName);
    }

    // Call this when Quit button is pressed
    public void QuitGame()
    {
        Debug.Log("Quit Game"); // Works in editor
        Application.Quit();     // Works in build
    }
}
