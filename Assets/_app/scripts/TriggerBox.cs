using System;
using Unity.VisualScripting;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace _app.scripts
{
    public class TriggerBox : MonoBehaviour
    {

        public static string previousLevel;
        public void OnTriggerExit(Collider other)
        {
            Debug.Log(other.transform.name + " Exited Trigger");
        }

        public IEnumerator OnCollisionEnter(Collision other)
        {
            if (transform.name == "Sphere")
                if (other.transform.CompareTag("net") )
                {
                    if (AudioManager.instance != null)
                    {
                        AudioManager.instance.PlayAudio();
                        while (AudioManager.instance.audioSource.isPlaying == true)
                        {
                            yield return null;
                        }
                    }
                    int milliseconds = 2000;
                    Thread.Sleep(milliseconds);
                    previousLevel = SceneManager.GetActiveScene().name;
                        
                    SceneManager.LoadScene("levelComplete", LoadSceneMode.Single);
                        
                        
                    Debug.Log("Go to menu");
                    
                   
                }
            Debug.Log(" Collided with object");   
            
        }
        public void OnCollisionExit(Collision other)
        {
            Debug.Log(" No Longer Colliding with object");
        }
    }
}