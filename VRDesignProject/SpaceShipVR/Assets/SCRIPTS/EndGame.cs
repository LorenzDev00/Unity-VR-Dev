using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // This method is called when another collider enters the trigger collider attached to the GameObject.
    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider belongs to a GameObject tagged with "Player".
        if (other.CompareTag("Player"))
        {
            // Call the method to quit the game.
            QuitGameFunction();

            // Log a message to the console indicating that the game has ended.
            Debug.Log("Game Ended");
        }
    }

    // This method handles quitting the game.
    public void QuitGameFunction()
    {
    #if UNITY_EDITOR
        // If running in the Unity Editor, stop play mode.
        UnityEditor.EditorApplication.isPlaying = false;
    #endif

        // If running as a standalone application, quit the application.
        Application.Quit();
    }
}
