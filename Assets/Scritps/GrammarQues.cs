using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GrammarQues : MonoBehaviour
{
    [System.Serializable]
    public class GrammarQuestion
    {
        public Sprite image;
        public string sentenceWithBlank;
        public string completedSentence;
        public List<string> options;
        public string correctAnswer;
    }

    public List<GrammarQuestion> grammarQuestions;

    public Image imageQuestion;
    public Text instructionText;
    public Text grammarSentenceText;
    public ToggleGroup toggleGroup;
    public List<Text> toggleTextList;
    public List<Toggle> toggleList; // Add reference to toggle components
    public GameObject goNextButton;
    public Image imageHighlight;

    public AudioClip acCorrect;
    public AudioClip acWrong;

    private AudioSource _audioSource;
    private int _currentQuestionIndex = -1;
    private int _correctAnswersCount = 0;
    private Text _textOptionSelected;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        ShowNextGrammarQuestion();
    }

    private void ShowNextGrammarQuestion()
    {
        _currentQuestionIndex++;

        if (_currentQuestionIndex >= grammarQuestions.Count)
        {
            GameOver();
            return;
        }

        GrammarQuestion q = grammarQuestions[_currentQuestionIndex];

        // Setup UI
        imageQuestion.sprite = q.image;
        imageQuestion.SetNativeSize();
        imageQuestion.gameObject.SetActive(true);

<<<<<<< Updated upstream
        instructionText.text = "Choose the correct answer";
=======
        instructionText.text = "Choose the correct grammar";
>>>>>>> Stashed changes
        instructionText.gameObject.SetActive(true);

        grammarSentenceText.text = q.sentenceWithBlank;
        grammarSentenceText.gameObject.SetActive(true);

        for (int i = 0; i < toggleTextList.Count; i++)
        {
            toggleTextList[i].text = q.options[i];
        }

        //  Ensure toggles are unticked when new question shows
        foreach (Toggle t in toggleList)
        {
            t.isOn = false;
        }

        toggleGroup.SetAllTogglesOff(true);
        toggleGroup.gameObject.SetActive(true);

        imageHighlight.gameObject.SetActive(false);
        goNextButton.SetActive(false);
    }

    public void OnToggleClick(Text selectedText)
    {
        _textOptionSelected = selectedText;
        goNextButton.SetActive(true);
    }

    public void OnNextClick()
    {
        GrammarQuestion q = grammarQuestions[_currentQuestionIndex];
        string selected = _textOptionSelected.text;
        grammarSentenceText.text = q.completedSentence;

        RectTransform targetRect = _textOptionSelected.transform.parent.GetComponent<RectTransform>();
        RectTransform highlightRect = imageHighlight.GetComponent<RectTransform>();
        highlightRect.anchoredPosition = targetRect.anchoredPosition;

        if (selected == q.correctAnswer)
        {
            imageHighlight.color = new Color32(41, 118, 6, 86); // Green
            _audioSource.clip = acCorrect;
            _correctAnswersCount++;
        }
        else
        {
            imageHighlight.color = new Color32(118, 11, 7, 86); // Red
            _audioSource.clip = acWrong;
        }

        _audioSource.Play();
        imageHighlight.gameObject.SetActive(true);
         toggleGroup.SetAllTogglesOff(true);
        

        StartCoroutine(WaitBeforeNext());
    }

    private IEnumerator WaitBeforeNext()
    {
        goNextButton.SetActive(false);

        yield return new WaitForSeconds(1.5f);

        imageHighlight.gameObject.SetActive(false);
        toggleGroup.gameObject.SetActive(false);
        grammarSentenceText.gameObject.SetActive(false);
        instructionText.gameObject.SetActive(false);
       

        yield return new WaitForSeconds(0.3f);

        ShowNextGrammarQuestion();
    }

    private void GameOver()
    {
        PlayerPrefs.SetInt("CorrectAnswers", _correctAnswersCount);
        SceneManager.LoadScene("End");
    }
}
