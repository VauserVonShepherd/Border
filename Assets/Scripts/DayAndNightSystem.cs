using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndNightSystem : MonoBehaviour {
    [SerializeField]
    private SpriteRenderer nightPanel;

    [SerializeField]
    private float maxDark = 0.9f;

    public void ToggleDayTo(string nightdaySetting, float speed)
    {
        StartCoroutine(nightdaySetting, speed);
    }

    private IEnumerator SetNight(float timeSpeed)
    {
        while (nightPanel.color.a < maxDark)
        {
            nightPanel.color = new Color(nightPanel.color.r, nightPanel.color.g, nightPanel.color.b,
            nightPanel.color.a + Time.deltaTime * 0.4f * timeSpeed);
            yield return null;
        }
    }

    private IEnumerator SetDay(float timeSpeed)
    {
        while (nightPanel.color.a > 0f)
        {
            nightPanel.color = new Color(nightPanel.color.r, nightPanel.color.g, nightPanel.color.b,
            nightPanel.color.a - Time.deltaTime * 0.4f * timeSpeed);
            yield return null;
        }
    }
}
