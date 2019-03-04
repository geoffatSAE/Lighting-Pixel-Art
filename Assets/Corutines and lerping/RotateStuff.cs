using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStuff : MonoBehaviour {

	Vector3 ourStartRotation, ourNextRotation;

	float elapsedTime = 0.0f;
	float timeToDestination = 2.0f;

	float timerToBegin;

	bool startANewRotation;

	// Use this for initialization
	void Start () {


		ourNextRotation = new Vector3 (0, 45.0f, 0);

	}
	
	// Update is called once per frame
	void Update () {
		timerToBegin += Time.deltaTime;
		if (timerToBegin >= 5.0f)
			startANewRotation = true;


		if (startANewRotation) {

			//store our current rotation
			ourStartRotation = transform.rotation.eulerAngles;
			//store our new rotation
			ourNextRotation = new Vector3 (0, Random.Range (0, 360), 0);

			//reset the timer
			elapsedTime = 0.0f;

			startANewRotation = false;

			timerToBegin = 0.0f;
		}



		if (timerToBegin > 2.0f) {

			//do our rotation lerp
			transform.rotation = Quaternion.Euler (Vector3.Lerp (ourStartRotation, ourNextRotation, (elapsedTime / timeToDestination)));
			elapsedTime += Time.deltaTime;
			Debug.Log (elapsedTime / timeToDestination);
		}
	}
}
