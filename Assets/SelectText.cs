using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SelectText : MonoBehaviour {

	public enum WeaponTypes { sword, axe, wand };
	public WeaponTypes weapons;

	[Header("value = 9")]
	public const int value = 9;


	// Update is called once per frame
	void Update () {

		Debug.Log (weapons.ToString ());

		//weapons = WeaponTypes.axe;
		//weapons = 0;

		switch (weapons) {

		case WeaponTypes.axe:

			Debug.Log ("axe axe");


			break;
		case 0:

			Debug.Log ("swod sord");

			break;

		}


		if ((int)weapons > 1) {
			
			Debug.Log ("wand is > 1");

		}

	}



}
