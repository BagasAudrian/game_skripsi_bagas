using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerSetting : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;

    public TMP_Text TextTimer;
    public bool keepTiming;
    [SerializeField] float startingTime = 60f;
    public float currentTime = 60f;

    private void Start()
    {
        currentTime = startingTime;
        keepTiming = true;
    }

    public float StopTiming()
    {
        keepTiming = false;
        return currentTime;
    }

    void UpdateTime()
    {
        currentTime -= 1 * Time.deltaTime;

        TextTimer.text = currentTime.ToString("0");
    }

    void Update()
    {
        UpdateTime();

        if (currentTime <= 0)
        {
            Gameover();
        }
    }

    public void Gameover()
    {
        gameOverPanel.SetActive(true);
    }
}
