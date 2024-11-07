using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class scoremanager : MonoBehaviour
{
    public static scoremanager Instance; // Singleton instance for global access
    public int score = 0; // The player's score
    public TextMeshProUGUI scoreText; // The UI Text component to display the score

    // Initialize the singleton
    private void Awake()
    {
        // Check if there is already an instance
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject); // If there is another instance, destroy this one
        }
    }

    // Method to add to the score
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreUI();
        if(score == 90){
            Debug.Log("You Win!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // Update the UI text with the new score
    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
