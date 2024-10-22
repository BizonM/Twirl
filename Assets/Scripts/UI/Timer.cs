using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TimerText;
    [SerializeField] private float startTime;

    private void Update()
    {
        startTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(startTime / 60);
        int seconds = Mathf.FloorToInt(startTime % 60);
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
