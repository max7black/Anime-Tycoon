using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSystem : MonoBehaviour {
    float time;
    int week, month, year, day;
    public int daycheck, weekcheck, monthcheck;
    Text text;
    bool cycleCheck; // checks if the increment for the time cycle already happened once so that it doesn't happen increment more than once a cycle

    void Start()
    {
        text = GetComponent<Text>();
        time = 0.0f;
        week = 1;
        month = 1;
        year = 1;
        day = 1;
        cycleCheck = false;
    }

    // Update is called once per frame
    void Update () {
        time += Time.deltaTime;
        if ((((int)time % daycheck) == 0) && (int)time > 1 && cycleCheck != true)
        {
            ++week;
            day = 1;
            cycleCheck = true;
        }

        if (week == weekcheck)
        {
            month++;
            week = 1;
        }
        if (month == monthcheck)
        {
            year++;
            month = 1;
        }

        if (((int)time % daycheck) != 0){
            cycleCheck = false;
        }
        text.text = "Y" + year.ToString() + "M" + month.ToString() + "W" + week.ToString() + "D" + ((int)time).ToString();

        
    }
}

