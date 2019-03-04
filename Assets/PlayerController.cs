using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Animator anim;

	float h, v;

	public float speed;

	// Use this for initialization
	void Start () {

		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");


		anim.SetFloat ("Horizontal", h);
		anim.SetFloat ("Vertical", v);


		transform.Translate (new Vector3 (h * speed * Time.deltaTime, v * speed * Time.deltaTime));

	}
}
