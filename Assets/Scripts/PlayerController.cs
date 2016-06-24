using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	private Rigidbody player;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float rotationSpeed;

	[SerializeField]
	private GameObject camera;

	void Start () {
		player = GetComponent<Rigidbody> ();
	}

	void Update () {
		player.transform.position += transform.forward * Time.deltaTime * (Input.GetAxis ("Vertical") * speed);
		player.transform.position += transform.right * Time.deltaTime * (Input.GetAxis ("Horizontal") * speed);
	}

}
