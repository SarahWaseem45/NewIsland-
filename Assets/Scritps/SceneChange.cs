using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void LoadNewScene()
    {
        SceneManager.LoadScene("Level 1"); 
    }
    public void Level2Scene()
    {
        SceneManager.LoadScene("Level 2"); 
    }
     public void MathScene()
    {
        SceneManager.LoadScene("Game"); 
    }
}
