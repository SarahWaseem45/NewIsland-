using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewQuestionList", menuName = "Quiz/Question List")]
public class QuestionList : ScriptableObject
{
    public List<Question> questions;
}
