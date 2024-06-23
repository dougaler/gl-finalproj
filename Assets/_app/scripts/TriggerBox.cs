using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace _app.scripts
{
    public class TriggerBox : MonoBehaviour
    {

        public void OnTriggerExit(Collider other)
        {
            Debug.Log(other.transform.name + " Exited Trigger");
        }

        public void OnCollisionEnter(Collision other)
        {
            if (transform.name == "Sphere")
                if (other.transform.tag == "net" )
                {
                    if (AudioManager.instance != null)
                    {
                        AudioManager.instance.PlayAudio();
                        
                    }
                    Debug.Log(other.transform.name + "Scored Point");
                   
                }
            Debug.Log(" Collided with object");   
            
        }
        public void OnCollisionExit(Collision other)
        {
            Debug.Log(" No Longer Colliding with object");
        }
    }
}