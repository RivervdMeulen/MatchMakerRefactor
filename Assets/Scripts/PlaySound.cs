using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PlaySound : MonoBehaviour, IEvents {

	//Get the sound
	[SerializeField]
	private AudioClip sound;

	//Get an audiosource to play the clip
	private AudioSource source;

	// Use this for initialization
	void Start () {
		//Prepare clip to be played
		source = gameObject.GetComponent<AudioSource> ();
		source.clip = sound;
	}

	public void OnClicked () {
		//Play clip
		source.Play ();
	}
}
