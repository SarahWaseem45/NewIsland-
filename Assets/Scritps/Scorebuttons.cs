using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorebuttons : MonoBehaviour
{  
    public void crosseasy()
    {
        SceneManager.LoadScene("Level 1");
    }
     public void replayeasygrammar()
    {
        SceneManager.LoadScene("EasyGrammar");
    }
      public void replayeasyGK()
    {
        SceneManager.LoadScene("EasyGK");
    }
     public void replayeasyspell()
    {
        SceneManager.LoadScene("EasySpellGame");
    }
    public void replayeasyMath()
    {
        SceneManager.LoadScene("EasyMath1 1");
    }
    public void crossmedium()
    {
        SceneManager.LoadScene("Level 2");
    }
     public void replaymediumgrammar()
    {
        SceneManager.LoadScene("MediumGrammar");
    }
     public void replaymediumGK()
    {
        SceneManager.LoadScene("MediumGK");
    }
     public void replaymediumspell()
    {
        SceneManager.LoadScene("MediumSpellGame");
    }
     public void replaymediumMath()
    {
        SceneManager.LoadScene("MediumMath1 2");
    }
     public void crossHard()
    {
        SceneManager.LoadScene("level 3");
    }
    public void replayhardgrammar()
    {
        SceneManager.LoadScene("HardGrammar");
    }
     public void replayhardGK()
    {
        SceneManager.LoadScene("HardGK");
    }
     public void replayhardspell()
    {
        SceneManager.LoadScene("HardSpellGame");
    }
     public void replayhardMath()
    {
        SceneManager.LoadScene("HardMath1");
    }
}
