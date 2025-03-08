using UnityEngine;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    public Image loadingBarImage; // Assign your UI Image in the Inspector

    public void SetProgress(float progress)
    {
        loadingBarImage.fillAmount = Mathf.Clamp01(progress); // Keep value between 0 and 1
    }
}
