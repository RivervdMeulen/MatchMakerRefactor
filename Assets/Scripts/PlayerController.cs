using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	//Get the player
	[SerializeField]
	private Rigidbody player;

	//Walking speed
	[SerializeField]
	private float speed;

	//Turning speed
	[SerializeField]
	private float rotationSpeed;

	//Camera gameobject
	[SerializeField]
	private GameObject camera;

	void Start () {
		player = GetComponent<Rigidbody> ();
	}

	void Update () {
		//Move body and camera based on mouse location
		player.transform.position += transform.forward * Time.deltaTime * (Input.GetAxis ("Vertical") * speed);
		player.transform.position += transform.right * Time.deltaTime * (Input.GetAxis ("Horizontal") * speed);
	}

}
