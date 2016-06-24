using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DisappearOnClick : MonoBehaviour, IEvents {

	public void OnClicked () {
		//Disappear when activated
		transform.localScale = new Vector3 (0, 0, 0);
		Destroy (gameObject);
	}
}
