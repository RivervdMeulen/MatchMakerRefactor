using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DisappearOnClick : MonoBehaviour, IEvents {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClicked () {
		transform.localScale = new Vector3 (0, 0, 0);
		Destroy (gameObject);
	}
}
