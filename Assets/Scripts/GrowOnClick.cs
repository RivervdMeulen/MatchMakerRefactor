using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class GrowOnClick : MonoBehaviour, IEvents {

	//Vector when grown
	[SerializeField]
	private Vector3 clickVector;

	//Normal vector
	[SerializeField]
	private Vector3 normalVector;

	//Speed of growing
	[SerializeField]
	private float speed;

	//Growing or not
	[SerializeField]
	private bool grow;

	// Update is called once per frame
	void Update () {
		//Check if it needs to grow or shrink, then either grow, shrink, or stay the same
		if (grow && checkSize()) {
			transform.localScale = Vector3.Lerp (transform.localScale, clickVector, Time.deltaTime * speed);
		} else if (grow && !checkSize()) {
			grow = false;
		} else if (!grow) {
			transform.localScale = Vector3.Lerp (transform.localScale, normalVector, Time.deltaTime * speed);
		}
	}

	//Start on activation
	public void OnClicked () {
		grow = true;
	}

	bool checkSize () {
		//Check current size for an object
		if (transform.localScale.x < clickVector.x -0.1f || transform.localScale.y < clickVector.y -0.1f || transform.localScale.z < clickVector.z -0.1f) {
			return true;
		} else {
			return false;
		}
	}
}
