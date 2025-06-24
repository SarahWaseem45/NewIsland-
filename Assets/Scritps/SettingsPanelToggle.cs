using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsPanelToggle : MonoBehaviour
{
    public GameObject settingsPanel;

    // Call this from the Settings button
    public void ToggleSettingsPanel()
    {
        bool isActive = settingsPanel.activeSelf;
        settingsPanel.SetActive(!isActive);
    }

    // Call this from the Back button inside the settings panel
    public void BackButton()
    {
        settingsPanel.SetActive(false);
        SceneManager.LoadScene("islands");
    }
     public void BackButton1()
    {
        settingsPanel.SetActive(false);
        SceneManager.LoadScene("Level 1");
    }
     public void BackButton2()
    {
        settingsPanel.SetActive(false);
        SceneManager.LoadScene("Level 2");
    }
     public void BackButton3()
    {
        settingsPanel.SetActive(false);
        SceneManager.LoadScene("level 3");
    }
}
