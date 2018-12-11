using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndNightSystem : MonoBehaviour {
    [SerializeField]
    SpriteRenderer nightPanel;

    [SerializeField]
    float MorningTime = 8, NightTime = 20;
    float currentTime;
    [SerializeField]
    float timeSpeed = 5;

	// Use this for initialization
	void Start () {
        StartDay();
	}

    void StartDay()
    {
        currentTime = MorningTime;
        StartCoroutine(RunDayAndNight());
    }

    private IEnumerator RunDayAndNight()
    {
        while(Time.timeScale > 0)
        {
            currentTime += Time.deltaTime * timeSpeed;
            
            if(currentTime > 23)
            {
                currentTime = 1;
            }

            switch (Mathf.RoundToInt(currentTime))
            {
                case 5:
                    StartCoroutine(SetDay());
                    break;

                case 17:
                    StartCoroutine(SetNight());
                    break;
            }
            
            GetComponent<UIManager>().txt_Time.text = (currentTime - (currentTime > 12 ? 11 : 0)).ToString("f0") + 
                (currentTime < 12 ? "A.M" : "P.M");

            yield return new WaitForSeconds(0);
        }
    }//end day and night


    private IEnumerator SetNight()
    {
        while (nightPanel.color.a < 0.9f)
        {
            nightPanel.color = new Color(nightPanel.color.r, nightPanel.color.g, nightPanel.color.b,
            nightPanel.color.a + Time.deltaTime * 0.005f * timeSpeed);
            yield return new WaitForSeconds(0);
        }
    }

    private IEnumerator SetDay()
    {
        while (nightPanel.color.a > 0f)
        {
            nightPanel.color = new Color(nightPanel.color.r, nightPanel.color.g, nightPanel.color.b,
            nightPanel.color.a - Time.deltaTime * 0.005f * timeSpeed);
            yield return new WaitForSeconds(0);
        }
    }
}
