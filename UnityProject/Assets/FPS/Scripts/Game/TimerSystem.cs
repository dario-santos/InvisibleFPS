using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSystem : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private IntVariable timer;
    [SerializeField] private int RoundTime = 60;

    private float startTimer;
    private float initialTimer;

    private void Start()
    {
        timer.value = RoundTime;
        startTimer = Time.time;
        initialTimer = timer.value;
    }

    private void Update()
    {
        if (startTimer + initialTimer - Time.time > 0)
            timer.value = (int)((startTimer + initialTimer) - Time.time);

        int minutos = timer.value / 60;
        int segundos = timer.value - (minutos * 60);

        // Todo: Add timer to UI
        text.text = string.Format("{0:D2}:{1:D2}", minutos, segundos);

        // Converter segundos para minutos
        // int(tempo / 60) -> minutos
        // segundos - (minutos * 60)

        // minutos + ":" + segundos


    }
}
