using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    private float timeRemaining;

    public float Duration = 60;
    public bool IsCountingDown = false;
    public GameAction GameAction;
    public Text Display;

    public void Start()
    {
        if (IsCountingDown)
        {
            StartTimer();
        }
    }

    public void StartTimer()
    {
        IsCountingDown = true;
        timeRemaining = Duration;
    }

    private void Update()
    {
        if (IsCountingDown)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                IsCountingDown = false;
                if (GameAction)
                {
                    GameAction.DoAction();
                }
            }

            if (Display)
            {
                Display.text = "Time Remaining: \n" + System.Math.Floor(timeRemaining);
            }
        }
    }
}