using UnityEngine;
using TMPro;

public class TimerClickHandler : MonoBehaviour
{
    public TMP_Text timerTextUI;
    public GameObject Timergameobject;
    public ClickCounter clickCounter;
    public float timer;
    public float starttimer;
    public int value;
    private bool isTimerRunning = true;

    void Start()
    {
        UpdateTimerText();
    }

    void Update()
    {
        Timergameobject.SetActive(true);
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
            gameObject.SetActive(false);
            Timergameobject.SetActive(false);
        }
    }

    void ResetTimer()
    {
        timer = starttimer;
        isTimerRunning = true;
        clickCounter.IncrementClickCount(value);
        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        timerTextUI.text = Mathf.Ceil(timer).ToString();
    }
}

