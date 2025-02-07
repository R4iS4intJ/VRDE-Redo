using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This method is called when the collider other enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            // Load the next scene (replace "NextSceneName" with the actual scene name)
            SceneManager.LoadScene("VRDE Redo S 5");
        }
    }
}