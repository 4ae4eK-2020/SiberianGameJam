using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private bool isPaused;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().name != "MainMenu") LoadMainMenu();
    }
    
    private void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void LoadScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void Pause()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            panel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
