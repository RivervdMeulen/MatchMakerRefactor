using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IEvents {

	//Objects to be activated on button interaction
	[SerializeField]
	private GameObject[] activations;

	public void OnClicked () {
		//For every object, activate it
		for (int i = 0; i < activations.Length; i++) {
			ExecuteEvents.Execute<IEvents> (activations[i], null, (x, y) => x.OnClicked());
		}
	}
}
