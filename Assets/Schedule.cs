using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[Serializable]
class Day
{
    public TMP_Text[] texts;
}

public class Schedule : MonoBehaviour
{
    [SerializeField] TMP_Text chatlog;
    [SerializeField] TMP_InputField inputday;

    [SerializeField] Day[] days;

    public int currentlist = 0;
    public int list;

    int currentDay = 0;

    void Start()
    {
        
    }

    public void ChangeCurrentDay(int day)
    {
        currentDay = day;
    }

    public void AddTask(string task)
    {
        int currentRow = 0;
        for (int i = 0; i < days[currentDay].texts.Length; i++)
        {
            if (days[currentDay].texts[i].text == "")
            {
                currentRow = i;
                break;
            }
        }
        days[currentDay].texts[currentRow].text = task;
    }
}



