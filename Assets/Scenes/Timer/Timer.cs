using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeSeconds = 0f;
    public float timeMinutes = 0f;
    public Text timeResult;

    // Start is called before the first frame update
    void Start()
    {
        timeResult.text = timeSeconds.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeSeconds += Time.deltaTime;
        if (timeSeconds >= 60f)
        {
            timeSeconds = 0f;
            ++timeMinutes;
        }

        timeResult.text = string.Format("{0:00}:{1:00}", Mathf.Floor(timeMinutes), Mathf.Floor(timeSeconds));
    }
}
