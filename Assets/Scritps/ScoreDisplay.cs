using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text finalScoreText;
    public Text highScoreText;

    void Start()
    {
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);
        int highScore = PlayerPrefs.GetInt("HighScore", 0);

        finalScoreText.text = "Your Score: " + finalScore;
        highScoreText.text = "High Score: " + highScore;
    }
}
