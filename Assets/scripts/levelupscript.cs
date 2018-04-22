using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelupscript : editor {

	public GameObject poper;
	void Start () {
		poper.SetActive (false);
	}
	void OnCollisionStay(Collision col){
		if (col.gameObject.tag == "sheep") {
			poper.SetActive (true);
			this.gameObject.SetActive (false);
		}
	}
}
