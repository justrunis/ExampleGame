using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
{
    private bool startedCounting;

    [SerializeField]
    private Text text;

    private int minuteCount;
    private float secondCount;
    private float milisecondCount;
    private string temp;
    private void Start()
    {
        startedCounting = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            Debug.Log("Start");
            startedCounting = true;
        }
        if (other.gameObject.layer == 9 && startedCounting)
        {
            Debug.Log("Stop");
            startedCounting = false;
        }
    }

    private void Update()
    {
        if (startedCounting)
        {
            UpdateTimer();
        }
    }
    private void UpdateTimer()
    {
        //secondCount += Time.deltaTime;
        milisecondCount += Time.deltaTime * 60;

        text.text = minuteCount + ":" + (int)secondCount + ":" + (int)milisecondCount;
        temp = minuteCount + ":" + (int)secondCount + ":" + (int)milisecondCount;
        Debug.Log(temp);
        if (secondCount >= 60)
        {
            minuteCount++;
            secondCount = 0;
        }
        if (milisecondCount > 60)
        {
            secondCount++;
            milisecondCount = 0;
        }

    }
}

