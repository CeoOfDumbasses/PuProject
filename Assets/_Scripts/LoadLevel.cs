using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevel : MonoBehaviour
{
public int levelIDToLoad = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LoadLevelByID(levelIDToLoad);
        }
    }

    public void LoadLevelByID(int id)
    {
        // Replace "GameScene" with your actual scene name
        SceneManager.LoadScene(id);
    }
}
