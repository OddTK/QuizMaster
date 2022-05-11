using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    // TextArea in this instance makes our text box for our question bigger
    // Takes 2 params: min number of lines, max number of lines
    [TextArea(2,6)]
    [SerializeField] string question = "Enter new question text here";
}
