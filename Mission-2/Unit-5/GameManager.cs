using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // List to hold different target objects
    public List<GameObject> targets;

    // Reference to the TextMeshProUGUI component for displaying score
    public TextMeshProUGUI scoreText;

    // Score variable to keep track of player's score
    private int score;

    // Rate at which targets spawn
    private float spawnRate = 1.0f;

    // Reference to the TextMeshProUGUI component for displaying game over text
    public TextMeshProUGUI gameOverText;

    // Reference to the Button component for restarting the game
    public Button restartGame;

    // Boolean to check if the game is over
    public bool gameIsOver = false;

    // Start is called before the first frame update
    void Start()
    {
        // Start spawning targets
        StartCoroutine(SpawnTarget());

        // Initialize score to zero and update score display
        score = 0;
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        // No code inside Update() for now
    }

    // Coroutine to spawn targets
    IEnumerator SpawnTarget()
    {
        // Keep spawning targets until gameIsOver becomes true
        while (gameIsOver == false) 
        {
            yield return new WaitForSeconds(spawnRate);
            // Randomly select a target from the list and instantiate it
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    // Method to update the score
    public void UpdateScore(int scoreToAdd)
    {
        // Add scoreToAdd to the score variable
        score += scoreToAdd;

        // Update the score text display
        scoreText.text = "Score: " + score;
    }

    // Method to handle game over event
    public void GameOver()
    {
        // Show game over text and restart button
        gameOverText.gameObject.SetActive(true);
        restartGame.gameObject.SetActive(true);

        // Set gameIsOver to true
        gameIsOver = true;
    }

    // Method to restart the game
    public void RestartGame()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
