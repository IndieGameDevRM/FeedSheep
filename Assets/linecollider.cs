using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linecollider : MonoBehaviour {
	[SerializeField]
	int line=0;
	[SerializeField]
	GameObject play;
	editor ed;
	int start=0;
	void Start(){
		play = GameObject.Find ("play");
	}
	void OnCollisionStay2D(Collision2D col){
		if (start == 0) {
			Debug.Log (col.gameObject.name);
			Debug.Log (line);
			start = 1;
		}

	}
	void OnCollisionExit2D(Collision2D col){
		start = 0;
	}

}
