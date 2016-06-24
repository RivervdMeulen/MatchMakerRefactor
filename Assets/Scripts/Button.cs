using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IEvents {

	[SerializeField]
	private GameObject[] activations;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClicked () {
		for (int i = 0; i < activations.Length; i++) {
			ExecuteEvents.Execute<IEvents> (activations[i], null, (x, y) => x.OnClicked());
		}
	}
}
