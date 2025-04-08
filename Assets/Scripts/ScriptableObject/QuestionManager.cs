using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class QuestionManager : MonoBehaviour
{
    private List<Question> currentQuestions;

    void Start()
    {
        LoadQuestionsForLevel();
    }

    void LoadQuestionsForLevel()
    {
        int currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);
        string path = $"Questions/Level{currentLevel}"; // e.g. Questions/Level1

        Question[] loadedQuestions = Resources.LoadAll<Question>(path);
        if (loadedQuestions.Length == 0)
        {
            Debug.LogWarning($"No questions found in Resources/{path}");
            return;
        }

        currentQuestions = new List<Question>(loadedQuestions);
    }

    public Question GetRandomQuestion()
    {
        if (currentQuestions == null || currentQuestions.Count == 0)
            return null;

        int index = Random.Range(0, currentQuestions.Count);
        Question q = currentQuestions[index];
        currentQuestions.RemoveAt(index);
        return q;
    }

    public void NextLevel()
    {
        int nextLevel = PlayerPrefs.GetInt("CurrentLevel", 1) + 1;
        if (nextLevel > 3)
        {
            Debug.Log("Game Over! All Levels Completed.");
            return;
        }

        PlayerPrefs.SetInt("CurrentLevel", nextLevel);
        SceneManager.LoadScene("Level" + nextLevel); // Make sure scene names are Level1, Level2, etc.
    }
}
