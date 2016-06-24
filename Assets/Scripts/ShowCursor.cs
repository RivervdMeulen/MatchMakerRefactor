using UnityEngine;
using System.Collections;

public class ShowCursor : MonoBehaviour {

	[SerializeField]
	private bool showCursor;

	private CameraLook cameraLook;

	// Use this for initialization
	void Start () {
		cameraLook = GetComponent<CameraLook> ();
	}
	
	// Update is called once per frame
	void Update () {
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
