using UnityEngine;
using System.Collections;

public class CameraLook : MonoBehaviour {

	//Get body object to rotate
	[SerializeField]
	private GameObject body;

	// Update is called once per frame
	void Update () {
			//Rotate the camera and body according to the mouse
			body.transform.Rotate (0, Input.GetAxis("MouseX"), 0);
			transform.Rotate (-Input.GetAxis ("MouseY"), 0f, 0f);
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, 0f);
	}
}
	