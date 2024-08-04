using System.Collections;
using UnityEngine;
using UnityEngine.Video;

namespace _app.scripts
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager instance;
        public new AudioClip audio;
        public AudioSource audioSource;
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

        public void PlayAudio()
        {
            audioSource.clip = audio;
            audioSource.Play();
        }
    }
}