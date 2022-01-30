using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Quiz Question", fileName ="New Question")]
public class QuestionSO : ScriptableObject
{[TextArea()]
    [SerializeField]string question= "Enter new question";
    [SerializeField] string[] answers= new string[4];
    [SerializeField] int correctAnswerIndex;
    public string GetAnswer(int index)
    {
        return answers[index];

    }
    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
    public string GetQuestion()
    {
        return question;
    }
}
