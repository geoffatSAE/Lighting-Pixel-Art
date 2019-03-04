using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFlicker : MonoBehaviour {
	public Sprite firstSprite, secondSprite;
	float timer;
	float RandomTimeToWait = 1.0f;
	public float staysSecond = 0.2f;

	SpriteRenderer SR;

	// Use this for initialization
	void Start () {
		SR = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		//add to the timer, the time since the last frame
		timer += Time.deltaTime;


		//check if the timer has hit the time limit
		if (timer >= RandomTimeToWait) {
			//reset the timer
			timer = 0.0f;

			RandomTimeToWait = Random.Range (0.2f, 2.0f);

			//change the sprite to the second
			SR.sprite = secondSprite;
		}


		if (timer >= staysSecond) {
			SR.sprite = firstSprite;

		}


	}
}
