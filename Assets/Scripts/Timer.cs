using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float timer = 120f;
    public AudioSource FireAlarm;

    void Start()
    {
        StartCoroutine(Timer1());
    }

    private IEnumerator Timer1()
    {
        do
        {
            timer -= Time.deltaTime;
            FormatText1();
            yield return null;
        }
        while (timer > 0);
    }

    public void FormatText1()
    {
        int minutes = (int)(timer / 60) % 60;
        int seconds = (int)(timer % 60);

        timerText.text = "";

        if (minutes < 10 && minutes > 0)
        {
            timerText.text += "0";
        }
        if (minutes > 0)
        {
            timerText.text += minutes + " : ";
        }
        if (seconds < 10 && seconds > 0)
        {
            timerText.text += "0";
        }
        if (seconds > 0)
        {
            timerText.text += seconds;
        }
        if (seconds == 0)
        {
            timerText.text += "00";
        }



        if (minutes == 0 && seconds == 0)
        {
            //UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}
