using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class QestionOne : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        CurrentTime();


    }

    public void CurrentTime()
    {
        string greeting;
        int hour = DateTime.Now.Hour;
        if (hour < 12) greeting = "good morning";
        else if (hour < 17) greeting = "good afternoon";
        else greeting = "good evening";

        //print(greeting + ", the current time is " + hour + ".");
        print(string.Format("Hello and {0}. My name is Nathan Ethington and the current time is {1}.", greeting, DateTime.Now.ToLongTimeString()));
    }


}
