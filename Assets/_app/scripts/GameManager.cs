using System;
using UnityEngine;

namespace _app.scripts
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public int playerScore;

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
    }
}