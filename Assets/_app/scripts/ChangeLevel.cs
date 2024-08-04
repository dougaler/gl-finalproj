using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _app.scripts
{
    public class ChangeLevel : MonoBehaviour
    {
        public static ChangeLevel instance;
        public static List<string> sceneList = new List<string>();

        public ChangeLevel()
        {
        }

        private void Awake()
        {
            if (instance != null)
            {
                Destroy(this);
            }
            else
            {
                instance = this;
            }
        }
        public void CompleteScene()
        {
            string sceneName = SceneManager.GetActiveScene().name;
            sceneList.Add(sceneName);
            SceneManager.LoadScene("levelComplete", LoadSceneMode.Single);
        }
        
        public void GoToLevel2()
        {
            string sceneName = SceneManager.GetActiveScene().name;
            sceneList.Add(sceneName);
            Debug.Log("Go to level 2");
            SceneManager.LoadScene("level2", LoadSceneMode.Single);
        }

        public void GoToLevel1()
        {
            string sceneName = SceneManager.GetActiveScene().name;
            sceneList.Add(sceneName);
            Debug.Log("Go to level 1");
            SceneManager.LoadScene("level1", LoadSceneMode.Single);
        }
        
    }
}