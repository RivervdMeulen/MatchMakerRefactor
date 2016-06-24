using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CursorChange : MonoBehaviour {

	[SerializeField]
	private Texture2D cursorNormal;

	[SerializeField]
	private Texture2D cursorInteract;

	private Ray interactRay;
	private RaycastHit interactRayHit;

	// Use this for initialization
	void Start () {
		Cursor.SetCursor (cursorNormal, new Vector2 (16, 16), CursorMode.Auto);
	}
	
	// Update is called once per frame
	void Update () {

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
