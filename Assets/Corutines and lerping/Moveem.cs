using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveem : MonoBehaviour {
	float elapsedTime = 0f;
	bool finished;
	bool checkArrivalIsRunning = false;

	//Array of positions to go to
	public Transform[] positionsToGoTo;

	public float timeToDestination;

	bool increment = false;

	public int currentDestination = 0;


	// Use this for initialization
	void Start () {

	}

	void Update(){

		if (!finished) {
			gameObject.transform.position = Vector3.Lerp (gameObject.transform.position, positionsToGoTo [currentDestination].position, (elapsedTime / timeToDestination));
			elapsedTime += Time.deltaTime;


			//Check if the corutine is running, if not Start the corutine to check if we've arrived
			if (checkArrivalIsRunning == false) {
				//iTween.MoveTo(gameObject, iTween.Hash("position", positionsToGoTo [currentDestination].position , "islocal", true, "time", 1.0f, "easetype", "linear"));
				checkArrivalIsRunning = true;
				StartCoroutine ("CheckArrival", currentDestination);
			}

			if (increment) {

				currentDestination++;
				elapsedTime = 0.0f;
				increment = false;


				//Check we're not at our final destination
				if (currentDestination == positionsToGoTo.Length) {
					finished = true;
				}
			}

		}
	}



	IEnumerator CheckArrival(int i){
		Debug.Log ("Starting CheckArrived");


		while (Vector3.Distance(transform.position, positionsToGoTo[i].transform.position) >= 0.1) {

			//Debug.Log ("Distance is " + Vector3.Distance (transform.position, positionsToGoTo [i].transform.position));


			yield return null;

		}

		Debug.Log ("while Loop completed");
		increment = true;
		checkArrivalIsRunning = false;
		StopCoroutine ("CheckArrival");


	}
}
