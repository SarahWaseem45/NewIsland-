using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadingBarController : MonoBehaviour
{
    public Slider loadingBar; // Reference to the slider UI element
    public GameObject loadingPanel; // Reference to the panel containing the loading bar
    public float loadingTime = 4f; // Total time for the loading process

    private bool isLoading = false;

    void Start()
    {
        // Ensure loading panel is initially active
        if (loadingPanel != null)
            loadingPanel.SetActive(true);

        if (loadingBar != null)
            loadingBar.value = 0f;

        // Start the loading process
        StartLoading();
    }

    public void StartLoading()
    {
        if (!isLoading)
        {
            StartCoroutine(ActivateLoadingBar());
        }
    }

    private IEnumerator ActivateLoadingBar()
    {
        isLoading = true;

        float elapsedTime = 0f;

        while (elapsedTime < loadingTime)
        {
            elapsedTime += Time.deltaTime;
            if (loadingBar != null)
                loadingBar.value = Mathf.Clamp01(elapsedTime / loadingTime); // Update slider
            yield return null;
        }

        // Ensure slider reaches full
        if (loadingBar != null)
            loadingBar.value = 1f;

        // **Load the next scene immediately**
        LoadNextScene();
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene("islands"); // Change "islands" to your scene name
    }
}
