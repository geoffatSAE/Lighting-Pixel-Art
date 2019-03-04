using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public GameObject player;
	public GameObject pointer;

	public GameObject currentNode;

	public enum PlayerDirection { North, South, East, West };
	public PlayerDirection playerDirection;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {


		if (player == null)
			return;

		//Debug.Log (Vector3.Angle (gameObject.transform.position, player.transform.position));
		//Debug.Log (AngleInDeg (gameObject.transform.position, player.transform.position));


		//rotate the pointer in the direction of the player
		pointer.transform.eulerAngles = new Vector3(pointer.transform.eulerAngles.x, -AngleInDeg (gameObject.transform.position, player.transform.position), pointer.transform.eulerAngles.z);


		//describe if the player is N S E W
		float tempAngle = AngleInDeg (gameObject.transform.position, player.transform.position);

		Debug.Log (tempAngle);

		//East
		if (tempAngle > -45.0f && tempAngle < 45.0f){
			playerDirection = PlayerDirection.East;
			Debug.Log ("East");
		} 

		//North
		if (tempAngle > 45.0f && tempAngle < 135.0f){
			playerDirection = PlayerDirection.North;
			Debug.Log ("North");
		}

		//West
		if (tempAngle > 135.0f || tempAngle < -135.0f){
			playerDirection = PlayerDirection.West;
			Debug.Log ("West");
		}

		//South
		if(tempAngle > -135.0f && tempAngle < -45.0f){
			playerDirection = PlayerDirection.South;
			Debug.Log("South");
		}
			




	}

	//Get the angle on the y axis in radians
	public static float AngleInRad(Vector3 vec1, Vector3 vec2){
		return Mathf.Atan2 (vec2.z - vec1.z, vec2.x - vec1.x);
	}

	//convert the radians to degrees
	public static float AngleInDeg(Vector3 vec1, Vector3 vec2)
	{
		return AngleInRad(vec1, vec2) * 180 / Mathf.PI;
	}




	public void Move(){
		//
		NodeScript tempNodeScript = currentNode.GetComponent<NodeScript> ();

		switch (playerDirection) {

		case PlayerDirection.North:
			if (tempNodeScript.north != null) {
				transform.position = tempNodeScript.north.transform.position;
				currentNode = tempNodeScript.north;
			}

			break;

		case PlayerDirection.South:

			if (tempNodeScript.south != null) {
				transform.position = tempNodeScript.south.transform.position;
				currentNode = tempNodeScript.south;
			}

			break;

		case PlayerDirection.East:
			if (tempNodeScript.east != null) {
				transform.position = tempNodeScript.east.transform.position;
				currentNode = tempNodeScript.east;
			}
			break;

		case PlayerDirection.West:
			if (tempNodeScript.west != null) {
				transform.position = tempNodeScript.west.transform.position;
				currentNode = tempNodeScript.west;
			}
			break;

		default:

			Debug.Log ("Error in Move Script for enemy");

			break;
		}


	}

}
