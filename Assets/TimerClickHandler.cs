using UnityEngine;
using TMPro;

public class TimerClickHandler : MonoBehaviour
{
    public TMP_Text timerTextUI;
    public TMP_Text clickTextUI;
    public float timer;
    public float starttimer;
    private int clickCount = 0;
    private bool isTimerRunning = true;

    void Start()
    {
        UpdateTimerText();
        UpdateClickCountText();
    }

    void Update()
    {
        if (isTimerRunning)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = 0;
                isTimerRunning = false;
            }
            UpdateTimerText();
        }
    }

    void OnMouseDown()
    {
        if (!isTimerRunning)
        {
            ResetTimer();
        }
    }

    void ResetTimer()
    {
        starttimer = starttimer + 3;
        timer = starttimer;
        isTimerRunning = true;
        clickCount++;
        UpdateClickCountText();
        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        timerTextUI.text = "Time: " + Mathf.Ceil(timer).ToString();
    }

    void UpdateClickCountText()
    {
        clickTextUI.text = "£: " + clickCount;
    }
}

