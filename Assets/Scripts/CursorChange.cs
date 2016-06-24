using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CursorChange : MonoBehaviour {

	//Standard cursor texture
	[SerializeField]
	private Texture2D cursorNormal;

	//Cursor texture on hover interactive object
	[SerializeField]
	private Texture2D cursorInteract;

	//Raycast ray
	private Ray interactRay;
	private RaycastHit interactRayHit;

	// Use this for initialization
	void Start () {
		//Set the standard cursor
		Cursor.SetCursor (cursorNormal, new Vector2 (16, 16), CursorMode.Auto);
	}
	
	// Update is called once per frame
	void Update () {

		//Set the standard cursor, check for interactive objects, and change cursor if an interactable object is found

		Cursor.SetCursor (cursorNormal, new Vector2 (16, 16), CursorMode.Auto);

		interactRay = Camera.main.ScreenPointToRay(Input.mousePosition);

		if(Physics.Raycast(interactRay, out interactRayHit))
		{
			if(interactRayHit.collider.tag == "Interactable")
			{
				Cursor.SetCursor (cursorInteract, new Vector2 (16, 16), CursorMode.Auto);
				if (Input.GetButton ("Action1")) {
					ExecuteEvents.Execute<IEvents> (interactRayHit.collider.gameObject, null, (x, y) => x.OnClicked());
				}
			}

		}
	
	}
}
