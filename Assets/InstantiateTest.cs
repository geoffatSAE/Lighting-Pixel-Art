using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTest : MonoBehaviour {


	public GameObject thGameObjectToInstantiate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetButtonDown("Fire1")){

			Instantiate (thGameObjectToInstantiate, transform.position, Quaternion.identity);

		}

	}
}
