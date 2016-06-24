using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CreateOnClick : MonoBehaviour, IEvents {

	//Object you want to spawn
	[SerializeField]
	private GameObject spawnObject;

	//Where you want to spawn the object
	[SerializeField]
	private Vector3 spawnLocation;

	//If you want to keep spawning the object
	[SerializeField]
	private bool repeat;

	//How often you want to repeat spawning the object
	[SerializeField]
	private int repeatAmount;

	private int repeatNew;
	private bool spawning = true;

	// Use this for initialization
	void Start () {
		//Remember repeat amount
		repeatNew = repeatAmount;
	}

	public void OnClicked () {
		//On activation, reset then start spawning
		repeatAmount = repeatNew;
		SpawnObjects ();
	}

	void SpawnObjects () {
		//Spawn object, then check if another object needs to be spawned
		if (spawning) {
			Instantiate(spawnObject, spawnLocation, Quaternion.identity);
			spawning = false;
			StartCoroutine (spawnDelay ());
		}
	}

	//Check if other object needs to be spawned, if yes, spawn it
	private IEnumerator spawnDelay () {
		yield return new WaitForSeconds (1);
		spawning = true;
		if (repeat && repeatAmount > 0) {
			SpawnObjects ();
			repeatAmount--;
		}
	}
}
