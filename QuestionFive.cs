using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionFive : MonoBehaviour {

    //Train 1
    int rateOne = 0;
    int timeOne = 0;

    //Train 2
    int rateTwo = 0;
    int timeTwo = 0;

    float distance = 0;

    // Use this for initialization
    void Start () {
        RandomizeDistance();
        print("A train leaves City A and drives west at " + rateOne + " mph. Another train leaves City A, at the same time, and drives east at " + rateTwo + " mph. How many miles apart are the trains after " + timeOne + " hours?");
        CalculateDistance();
        print("Answer: " + distance + " miles.");
	}

    public void RandomizeDistance()
    {
        rateOne = (Random.Range(0, 100));
        rateTwo = (Random.Range(0, 100));
        timeOne = (Random.Range(0, 100));
        timeTwo = timeOne;
    }

    public void CalculateDistance()
    {
        distance = (rateOne * timeOne) + (rateTwo * timeTwo);
    }
}
