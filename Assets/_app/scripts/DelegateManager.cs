using UnityEngine;

public class DelegateManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CallBackSystem.OnSpace += Space;
    }

    // Update is called once per frame
    void Space(Color color)
    {
        transform.GetComponent<Renderer>().material.color = color;
    }
}
