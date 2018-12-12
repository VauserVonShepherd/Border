using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeSystem : MonoBehaviour {
    [SerializeField]
    private float MorningTime = 8, NightTime = 20;
    private float currentTime;
    [SerializeField]
    private float timeSpeed = 5;
    [SerializeField]
    private int speedMode = 0;

    [SerializeField]
    private DayAndNightSystem dayandnightSystem;

    public UnityEvent startDayEvent;
    
    // Use this for initialization
    void Start()
    {
        StartDay();
    }

    void StartDay()
    {
        startDayEvent.Invoke();
        currentTime = MorningTime;
        StartCoroutine(RunDayAndNight());
    }

    private IEnumerator RunDayAndNight()
    {
        while (Time.timeScale > 0)
        {
            ++currentTime;

            if (currentTime > 23)
            {
                currentTime = 1;
            }

            switch (Mathf.RoundToInt(currentTime))
            {
                case 5:
                    dayandnightSystem.ToggleDayTo("SetDay", timeSpeed);
                    //StartCoroutine(SetDay());
                    break;

                case 17:
                    dayandnightSystem.ToggleDayTo("SetNight", timeSpeed);
                    //StartCoroutine(SetNight());
                    //playNight();
                    break;

                case 1:
                    startDayEvent.Invoke();
                    //DayEndedMethods.Invoke();
                    break;
            }

            GetComponent<UIManager>().txt_Time.text = (currentTime - (currentTime > 12 ? 11 : 0)).ToString("f0") +
                (currentTime < 12 ? "A.M" : "P.M");

            yield return new WaitForSeconds(1 / timeSpeed);
        }
    }//end day and night

    public void Btn_ToggleSpeed()
    {
        ++speedMode;

        if(speedMode == 3) {
            speedMode = 0;
        }

        switch (speedMode) {
            case 0:
                timeSpeed = 1;
                break;

            case 1:
                timeSpeed = 2;
                break;

            case 2:
                timeSpeed = 5;
                break;
        }
    }
}
