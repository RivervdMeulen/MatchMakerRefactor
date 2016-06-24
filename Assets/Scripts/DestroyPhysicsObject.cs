using UnityEngine;
using System.Collections;

public class DestroyPhysicsObject : MonoBehaviour {

	//Lowest position before the object will self-destrupt
	[SerializeField]
	private float minPos;

	// Update is called once per frame
	void Update () {
		//Delete gameobject if it gets too low
		if (transform.position.y <= minPos) {
			Destroy (gameObject);
		}
	}
}
