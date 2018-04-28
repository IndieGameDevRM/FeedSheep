using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastingneighbour : MonoBehaviour {
	//[SerializeField]
	//GameObject[] blocks;
	//[SerializeField]
	//GameObject parent;
	[SerializeField]
	Behaviour CodeWindow;
	void FixedUpdate(){
		CodeWindow.enabled = false;	
		Vector2 up = transform.TransformDirection (-Vector2.up) * 100;
		Debug.DrawRay (transform.position, up, Color.blue);
		RaycastHit2D hit = Physics2D.Raycast (transform.position, -Vector2.up,100f);

		if (hit.collider!= null) {
			Transform objectHit = hit.collider.transform;
			Debug.Log (hit.collider.name);
		}
	}
}
