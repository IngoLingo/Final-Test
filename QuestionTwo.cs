using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionTwo : MonoBehaviour {
    // Enter your two numbers and start the game
    public int numOne;
    public int numTwo;
    // Use this for initialization
    void Start () {
        print(numOne + " + " + numTwo + " equals " + (numOne + numTwo));
        print(numOne + " - " + numTwo + " equals " + (numOne - numTwo));
        print(numOne + " * " + numTwo + " equals " + (numOne * numTwo));
        if (numTwo != 0)
        {
            print(numOne + " / " + numTwo + " equals " + (numOne / numTwo));
        }
        else print("You can not devide by zero.");

    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
