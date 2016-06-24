using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CreateOnClick : MonoBehaviour, IEvents {

	[SerializeField]
	private GameObject spawnObject;

	[SerializeField]
	private Vector3 spawnLocation;

	[SerializeField]
	private bool repeat;

	[SerializeField]
	private int repeatAmount;

	private int repeatNew;
	private bool spawning = true;

	// Use this for initialization
	void Start () {
		repeatNew = repeatAmount;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClicked () {
		repeatAmount = repeatNew;
		SpawnObjects ();
	}

	void SpawnObjects () {
		if (spawning) {
			Instantiate(spawnObject, spawnLocation, Quaternion.identity);
			spawning = false;
			StartCoroutine (spawnDelay ());
		}
	}

	private IEnumerator spawnDelay () {
		yield return new WaitForSeconds (1);
		spawning = true;
		if (repeat && repeatAmount > 0) {
			SpawnObjects ();
			repeatAmount--;
		}
	}
}
