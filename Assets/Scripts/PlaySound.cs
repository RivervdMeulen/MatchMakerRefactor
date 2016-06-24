using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PlaySound : MonoBehaviour, IEvents {

	[SerializeField]
	private AudioClip sound;

	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = gameObject.GetComponent<AudioSource> ();
		source.clip = sound;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClicked () {
		source.Play ();
	}
}
