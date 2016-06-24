using UnityEngine;
using System.Collections;

public class DestroyPhysicsObject : MonoBehaviour {

	[SerializeField]
	private float minPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= minPos) {
			Destroy (gameObject);
		}
	}
}
