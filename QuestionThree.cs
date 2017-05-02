using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QuestionThree : MonoBehaviour {

    public List<int> numbers = new List<int>();

    // Use this for initialization
    void Start () {
        numbers.Add(Random.Range(0, 100));
        numbers.Add(Random.Range(0, 100));
        numbers.Add(Random.Range(0, 100));
        numbers.Add(Random.Range(0, 100));
        numbers.Add(Random.Range(0, 100));
        

        PrintAvg();
    }

	
	// Update is called once per frame
	void Update () {
		
	}

    public void PrintAvg()
    {
        int i = 0;
        float avg = numbers.Sum();
        while (i < numbers.Count)
        {
            print("Number " + (i + 1) + " is " + numbers[i++]);
        }
        print("The average is " + avg / numbers.Count );
    }
}
