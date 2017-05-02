using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionFour : MonoBehaviour {

    int inches = 0;
    int feet = 0;

	// Use this for initialization
	void Start () {

        InchesToFeet();

	}


    public void InchesToFeet()
    {
        inches = (Random.Range(0, 100));
        print(inches + " inches is equal to ");

        while (12 < inches)
        {
            inches = inches - 12;
            feet++;
        }
        print(feet + "'" + inches + "''");
    }
}