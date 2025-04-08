using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PausePanel : MonoBehaviour
{
    public GameObject pausePanel;  // Reference to the pause UI panel
    public Text timerText; // UI text for displaying the timer
    public Text questionText; // UI text for displaying the question

    private float timeRemaining = 30f; // Initial countdown timer
    private bool isPaused = false;  // Track game pause state
    private bool hasTimer = true;  // Check if the question has a timer
    private string currentQuestion = ""; // Store the current question

    void Start()
    {
        // Initialize question and timer
        SetQuestion("Default Question?");
    }

    void Update()
    {
        if (!isPaused && hasTimer && timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerUI();
        }
    }

    // Function to Pause the Game
    public void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;  // Pause game time
        isPaused = true;
    }

    // Function to Resume the Game
    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;  // Resume game time
        isPaused = false;
    }

    // Function to Restart the Level
    public void RestartGame()
    {
        Time.timeScale = 1f; // Reset time scale
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reload current scene
    }

    // Function to Go to Home (Level 1)
    public void HomeGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 1");
    }

    // Function to Go to Home (Level 2)
    public void Home2Game()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 2");
    }
    // Function to Go to Home (Level 2)
    public void Home3Game()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("level 3");
    }

    // Update the Timer UI
    void UpdateTimerUI()
    {
        if (timerText != null)
        {
            timerText.text = hasTimer ? "Time: " + Mathf.Ceil(timeRemaining).ToString() : "No Timer";
        }
    }

    // Set Question and Control Timer
    public void SetQuestion(string question, bool useTimer = true, float questionTime = 30f)
    {
        currentQuestion = question;
        hasTimer = useTimer;
        timeRemaining = questionTime;

        if (questionText != null)
        {
            questionText.text = currentQuestion;
        }

        UpdateTimerUI();
    }
}
