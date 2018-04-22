using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoAboutNeighbourBlock : MonoBehaviour {
	Vector2 direction;

	void Start () {
		Vector2 up = transform.TransformDirection (-Vector2.up)*50;
		Debug.DrawRay (transform.position, up, Color.green);
		RaycastHit2D hit = Physics2D.Raycast (transform.position, -Vector2.up);
		//If something was hit
		if (hit.collider != null) {
			Transform objectHit = hit.transform;
			StoringinfoAboutNeighbours storage = new StoringinfoAboutNeighbours (objectHit.name);
		}
	}
}
