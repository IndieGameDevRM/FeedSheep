using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodcheckpointcheck : MonoBehaviour {

	[SerializeField]
	GameObject poper;
	void Start(){
		
	}
	void FixedUpdate () {
		if (this.gameObject.transform.childCount == 0) {
			poper.SetActive (true);
			this.gameObject.SetActive (false);
		}
	}
}
