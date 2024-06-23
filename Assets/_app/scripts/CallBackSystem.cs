using UnityEngine;
using System;
using Unity.VisualScripting;

public class CallBackSystem : MonoBehaviour
{
    
    public static CallBackSystem Instance;
    
    public delegate void ChangeCubeColor(Color color);

    public static event ChangeCubeColor OnSpace;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (OnSpace != null)
            {
                OnSpace(Color.red);
            }
        }    
    }
}
