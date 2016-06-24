using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class GrowOnClick : MonoBehaviour, IEvents {

	[SerializeField]
	private Vector3 clickVector;

	[SerializeField]
	private Vector3 normalVector;

	[SerializeField]
	private float speed;

	[SerializeField]
	private bool grow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (grow && checkSize()) {
			transform.localScale = Vector3.Lerp (transform.localScale, clickVector, Time.deltaTime * speed);
		} else if (grow && !checkSize()) {
			grow = false;
		} else if (!grow) {
			transform.localScale = Vector3.Lerp (transform.localScale, normalVector, Time.deltaTime * speed);
		}
	}

	public void OnClicked () {
		grow = true;
	}

	bool checkSize () {
		if (transform.localScale.x < clickVector.x -0.1f || transform.localScale.y < clickVector.y -0.1f || transform.localScale.z < clickVector.z -0.1f) {
			return true;
		} else {
			return false;
		}
	}
}
