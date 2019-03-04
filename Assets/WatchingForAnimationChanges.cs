using UnityEngine;

public class WatchingForAnimationChanges : MonoBehaviour
{
	private Animator animator;                          // Reference to the Animator component on this gameobject.
	private watchforanimatorstates exampleSmb;    // Reference to a single StateMachineBehaviour.


	void Awake ()
	{
		// Find a reference to the Animator component in Awake since it exists in the scene.
		animator = GetComponent <Animator> ();
	}


	void Start ()
	{
		// Find a reference to the watchforanimatorstate in Start since it might not exist yet in Awake.
		exampleSmb = animator.GetBehaviour <watchforanimatorstates> ();



		// Set the StateMachineBehaviour's reference to an ExampleMonoBehaviour to this.
		exampleSmb.exampleMb = this;
		exampleSmb.SR = GetComponent<SpriteRenderer> ();


	}


}