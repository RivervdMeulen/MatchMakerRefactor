using UnityEngine;
using System.Collections;

public class ShowCursor : MonoBehaviour {

	//Should cursor be shown
	[SerializeField]
	private bool showCursor;

	//Get camera
	private CameraLook cameraLook;

	// Use this for initialization
	void Start () {
		cameraLook = GetComponent<CameraLook> ();
	}
	
	// Update is called once per frame
	void Update () {
		//If action2 button is pressed, swap if cursor is shown or moving the view
		if (Input.GetButton ("Action2")) {
			showCursor = !showCursor;
		}

		if (showCursor) {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			cameraLook.enabled = false;
		} else {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
			cameraLook.enabled = true;
		}
	}
}
