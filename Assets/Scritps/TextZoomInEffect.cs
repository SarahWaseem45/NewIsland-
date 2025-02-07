using UnityEngine;
using TMPro;

public class TextZoomInEffect : MonoBehaviour
{
    public float duration = 2.5f;
    public Vector3 startScale = new Vector3(0.3f, 0.3f, 0.3f);
    public Vector3 endScale = new Vector3(1.2f, 1.2f, 1.2f);
    public float startY = 20f; 

    private RectTransform textTransform;
    private float elapsedTime = 0f;

    void Start()
    {
        textTransform = GetComponent<RectTransform>();
        textTransform.localScale = startScale;
        textTransform.anchoredPosition += new Vector2(0, startY); 
    }

    void Update()
    {
        if (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float progress = elapsedTime / duration;
            textTransform.localScale = Vector3.Lerp(startScale, endScale, progress);
        }
    }
}
