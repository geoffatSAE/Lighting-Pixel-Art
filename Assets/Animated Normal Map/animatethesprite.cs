using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatethesprite : MonoBehaviour {

	SpriteRenderer SR;

	public float timer;

	public Sprite[] sprites;
	public Material[] mats;
	public int frame = 0;

	// Use this for initialization
	void Start () {

		SR = GetComponent<SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		if (timer >= 1.0f) {
			timer = 0.0f;

			Debug.Log ("Frame");


			if (frame == 0) {
				//play frame 1

				SR.sprite = sprites [1];
				SR.material = mats [1];

				frame = 1;
			} else { 
				//play frame 0
				SR.sprite = sprites [0];
				SR.material = mats [0];

				frame = 0;

			}

		}




	}
}
