using _app.scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public static ButtonManager changeScene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetTheGame()
    {
        Debug.Log("Restart Level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToLevel2()
    {
        Debug.Log("Go to level 2");
        SceneManager.LoadScene("level2", LoadSceneMode.Single);
    }

    public void GoToLevel1()
    {
        Debug.Log("Go to level 1");
        SceneManager.LoadScene("level1", LoadSceneMode.Single);
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(TriggerBox.previousLevel, LoadSceneMode.Single);
    }
    
}
