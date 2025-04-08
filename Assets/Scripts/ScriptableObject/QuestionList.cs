using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewQuestionList", menuName = "Quiz/QuestionList")]
public class QuestionList : ScriptableObject
{
    public List<Question> questions;
}

[System.Serializable]
public class QuizQuestion // Renamed from Question to QuizQuestion
{
    public string questionText;
    public List<string> answers;
    public int correctAnswerIndex;
}
