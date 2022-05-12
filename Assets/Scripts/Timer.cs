using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    public bool isAnsweringQuestion = false;
    float timerValue;

    void Update()
    {
        // on every second update timer will run
        UpdateTimer();
    }

    void UpdateTimer()
    {
        // timerValue is equal to timerValue - time.deltatime
        timerValue -= Time.deltaTime;
        // if the player is answering a question but if the timer reaches zero then
        // isAnsweringQuestion is false and time to show correct answer will trigger
        if(isAnsweringQuestion)
        {
            if(timerValue <= 0)
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            // else if player is answering a question then time to answer the question till run
            if(timerValue <= 0)
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
            }
        }
    }
}
