using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    private int completetPlanets;
    public GameObject winObject;
    public float startTime = 5;
    private float timerTime;
    public GameObject loseObject;
    public TMP_Text timerText;

    private void Awake()
    {
        timerTime = startTime;
    }

    private void Update()
    {
        Countdown();
    }

    public void CompletetPlanet()
    {
        completetPlanets++;
        if(completetPlanets >= 3)
        {
            GameWon();
        }
    }

    private void GameWon()
    {
        winObject.SetActive(true);
    }

    private void Countdown()
    {

        if (timerTime > 0)
        {
            timerText.text = FormatTime(timerTime);
            timerTime -= Time.deltaTime;
        }
        if(timerTime <= 0)
        {
            loseObject.SetActive(true);
            timerText.text = FormatTime(0);
            Time.timeScale = 0;
        }
    }
    public static string FormatTime(float time)
    {
        int minutes = (int)time / 60;
        int seconds = (int)time - 60 * minutes;
        int milliseconds = (int)(1000 * (time - minutes * 60 - seconds));
        return $"{minutes:00}:{seconds:00}:{milliseconds:000}";
    }
}
