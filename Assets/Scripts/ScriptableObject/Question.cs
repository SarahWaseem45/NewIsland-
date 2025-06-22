using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct Answer
{
    [SerializeField] private string _info;
    public string Info { get { return _info; } }

    [SerializeField] private bool _isCorrect;
    public bool IsCorrect { get { return _isCorrect; } }
}

[CreateAssetMenu(fileName = "New Question", menuName = "Quiz/New Question")]
public class Question : ScriptableObject
{
    public enum AnswerType { Multi, Single }

    [SerializeField] private string _info = string.Empty;
    public string Info => _info;

    [SerializeField] private Answer[] _answers = null;
    public Answer[] Answers => _answers;

    [SerializeField] private bool _useTimer = false;
    public bool UseTimer => _useTimer;

    [SerializeField] private int _timer = 0;
    public int Timer => _timer;

    [SerializeField] private AnswerType _answerType = AnswerType.Multi;
    public AnswerType GetAnswerType => _answerType;

    [SerializeField] private int _addScore = 10;
    public int AddScore => _addScore;

    public List<int> GetCorrectAnswers()
    {
        List<int> correctAnswers = new List<int>();
        for (int i = 0; i < _answers.Length; i++)
        {
            if (_answers[i].IsCorrect)
            {
                correctAnswers.Add(i);
            }
        }
        return correctAnswers;
    }
}
