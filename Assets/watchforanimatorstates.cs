using UnityEngine;

public class watchforanimatorstates : StateMachineBehaviour {

	public WatchingForAnimationChanges exampleMb;


	public SpriteRenderer SR; //this would need to be assigned at runtime
	public Sprite[] sprites;
	public Material[] mats;


	override public void OnStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		//Debug.Log ("changing state");
		//Debug.Log (stateInfo);

		//Check which animation state we're moving into
		if (stateInfo.IsName ("AnimationTest1")) {
			Debug.Log ("is animationtest1");



		}
	}



	override public void OnStateUpdate (Animator animator, AnimatorStateInfo stateInfo, int layerIndex){


		//Check which animation state we're moving into

		if (stateInfo.IsName ("AnimationTest1")) {
			Debug.Log ("is AnimationTest1 frame tick");


			//Debug.Log(SR.sprite.name);
			//if (SR.sprite.name == "Rogue Front Walk 2 Resized") {
			if(SR.sprite == sprites[0]){
				Debug.Log ("image 2");
				//set the appropriate material
				SR.material = mats[0];
			}

			//if (SR.sprite.name == "Rogue Front Walk 3 Resized") {
			if(SR.sprite == sprites[1]){
				
				Debug.Log ("image 3");
				//set the appropriate material
				SR.material = mats [1];
			}

		}

		if (stateInfo.IsName ("idle")) {

			Debug.Log ("Idle is animating");

			if(SR.sprite == sprites[2]){

				Debug.Log ("image idle");
				//set the appropriate material
				SR.material = mats [2];
			}
		}

	}
}
