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
     public void EasyMath()
    {
        SceneManager.LoadScene("Easy Math"); 
    }
     public void SpellingScene()
    {
        SceneManager.LoadScene("spell game"); 
    }
     public void Level3Scene()
    {
        SceneManager.LoadScene("level 3"); 
    }
     public void MediumMath()
    {
        SceneManager.LoadScene("Medium Math"); 
    }
    public void HardMath()
    {
        SceneManager.LoadScene("Hard Math"); 
    }
     public void EasySpellGame()
    {
        SceneManager.LoadScene("EasySpellGame"); 
    }
     public void MediumSpellGame()
    {
        SceneManager.LoadScene("MediumSpellGame"); 
    }
     public void HardSpellGame()
    {
        SceneManager.LoadScene("HardSpellGame"); 
    }
     public void BackGame()
    {
        SceneManager.LoadScene("islands"); 
    }
}
