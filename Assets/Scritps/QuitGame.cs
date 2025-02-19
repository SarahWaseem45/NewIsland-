using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        quitButton.onClick.AddListener(Quit);    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
        #if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
    #endif
    }
}
