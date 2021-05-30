using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private IntVariable timer;

    private float startTimer;
    private float initialTimer;

    private void Start()
    {
        startTimer = Time.time;
        initialTimer = timer.value;
    }

    private void Update()
    {
        if (startTimer + initialTimer - Time.time > 0)
            timer.value = (int)((startTimer + initialTimer) - Time.time);

        // Todo: Add timer to UI
        text.SetText(timer.value.ToString());
    }
}
