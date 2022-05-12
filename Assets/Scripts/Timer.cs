using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    public bool loadNextQuestion;
    public bool isAnsweringQuestion = false;
    public float fillFraction;
    float timerValue;

    void Update()
    {
        // on every second update timer will run
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        // timerValue is equal to timerValue - time.deltatime
        timerValue -= Time.deltaTime;
        // if the player is answering a question but if the timer reaches zero then
        // isAnsweringQuestion is false and time to show correct answer will trigger
        if(isAnsweringQuestion)
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            // else if player is answering a question then time to answer the question till run
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
        Debug.Log(isAnsweringQuestion + ": " + timerValue + " = " + fillFraction);
    }
}
