using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelupscript : editor {

	[SerializeField]
	GameObject DestroyGameObject;
	public GameObject poper;
	void Start () {
		poper.SetActive (false);
	}
	void OnCollisionStay(Collision col){
		if (col.gameObject.tag == "sheep") {

			poper.SetActive (true);
			for (int i=0;i<=DestroyGameObject.transform.childCount-1;i++) {
				Destroy(DestroyGameObject.transform.GetChild(i).gameObject);
				print (DestroyGameObject.transform.GetChild (i).gameObject.name);
			}
			this.gameObject.SetActive (false);

		}
	}
}
