using UnityEngine;
using System.Collections;

public class CameraLook : MonoBehaviour {

	[SerializeField]
	private GameObject body;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			body.transform.Rotate (0, Input.GetAxis("MouseX"), 0);
			transform.Rotate (-Input.GetAxis ("MouseY"), 0f, 0f);
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, 0f);
	}
}
	