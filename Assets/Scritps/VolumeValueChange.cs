using UnityEngine;
using UnityEngine.UI;

public class VolumeValueChange : MonoBehaviour
{
    private AudioSource audioSource;
    public Slider volumeSlider;

    void Start()
    {
        GameObject musicObj = GameObject.FindWithTag("GameMusic");
        audioSource = musicObj.GetComponent<AudioSource>();

        float savedVolume = PlayerPrefs.GetFloat("volume", 1f);
        audioSource.volume = savedVolume;
        volumeSlider.value = savedVolume;

        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
        PlayerPrefs.SetFloat("volume", volume);
    }
}
