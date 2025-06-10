using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PausePanel : MonoBehaviour
{
    public GameObject pausePanel;     // Reference to the pause UI panel
    public GameObject blurPanel;      // Reference to the background blur panel (RawImage with blur material)
    public Text timerText;            // UI text for displaying the timer
    public Text questionText;         // UI text for displaying the question

    private float timeRemaining = 30f; // Initial countdown timer
    private bool isPaused = false;     // Track game pause state
    private bool hasTimer = true;      // Check if the question has a timer
    private string currentQuestion = ""; // Store the current question

    void Start()
    {
        SetQuestion("Default Question?");
        pausePanel.SetActive(false);
        if (blurPanel != null) blurPanel.SetActive(false);
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
        if (blurPanel != null) blurPanel.SetActive(true); // Enable blur background
        pausePanel.SetActive(true);
        Time.timeScale = 0f;  // Pause game time
        isPaused = true;
    }

    // Function to Resume the Game
    public void ResumeGame()
    {
        if (blurPanel != null) blurPanel.SetActive(false); // Disable blur background
        pausePanel.SetActive(false);
        Time.timeScale = 1f;  // Resume game time
        isPaused = false;
    }

    // Function to Restart the Level
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

    // Function to Go to Home (Level 3)
    public void Home3Game()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 3");
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
