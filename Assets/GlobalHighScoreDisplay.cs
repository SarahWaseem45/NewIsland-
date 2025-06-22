using UnityEngine;
using UnityEngine.UI;

public class GlobalHighScoreDisplay : MonoBehaviour
{
    public Text highScoreText; // 🎯 Drag your UI Text here in Inspector

    void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0); // Read saved high score
        highScoreText.text = "Total : " + highScore;
    }
}
