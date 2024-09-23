using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    public string firstScene;  // Name of the first scene
    public string secondScene; // Name of the second scene

    public void RestartGameFunction()
    {
        // Get the scene by its name to check if it is loaded
        Scene secondSceneCheck = SceneManager.GetSceneByName(secondScene);

        // If the second scene is loaded, load the first scene and unload the second one afterward
        if (secondSceneCheck.isLoaded)
        {
            // Load the first scene, but use LoadSceneMode.Single to ensure it's the only active scene
            SceneManager.LoadScene(firstScene, LoadSceneMode.Single);
            // Now we don't need to unload the second scene manually; Unity automatically unloads the inactive scene
        }
        else
        {
            // If the second scene is not loaded, simply reload the first scene
            SceneManager.LoadScene(firstScene);
        }
    }
}
