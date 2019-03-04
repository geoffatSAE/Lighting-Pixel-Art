using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTimer : MonoBehaviour {

	float timer = 0.0f;
	float timer2 = 0.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		//do stuf

		//option 1
		if (timer <= 1.5f) {
			//timer is less than 1.5
			//Debug.Log (timer);
			timer += Time.deltaTime;
		} else {
			//Timer is greater than 1.5
			//DO a thing
			Debug.Log("Reset");
			timer = 0.0f; //reset the timer
		}


		//option 2
		if (timer2 >= 1.5f) {

			Debug.Log("Timer 2 Reset, do something");
			timer2 = 0.0f; //reset the timer
		}
		timer2 += Time.deltaTime;

	}
}
