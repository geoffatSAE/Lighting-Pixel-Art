using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashing : MonoBehaviour {

	public Light light;
	public bool randomflashHigh;
	public float flashIntensity;


	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (randomflashHigh) {
			flashIntensity = Random.RandomRange (6.0f, 8.0f);
			randomflashHigh = false;
		} else {
			flashIntensity = Random.RandomRange (0.0f, 1.0f);

			randomflashHigh = true;
		}


		light.intensity = flashIntensity;



	}
}
