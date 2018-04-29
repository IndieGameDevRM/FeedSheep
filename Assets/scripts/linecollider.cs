using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linecollider : MonoBehaviour {
	public static int[] arr=new int[10];
	int turn=0;
	[SerializeField]
	int line=0;
	[SerializeField]
	GameObject play;
	public GameObject[] blocks;
	public GameObject parent;
	bool action=false;
	void Start(){
		play = GameObject.Find ("play");
		//blocks [0] = GameObject.FindGameObjectWithTag ("move10");
		//blocks [1] = GameObject.FindGameObjectWithTag("Backward");
		parent = GameObject.Find ("CodeWillImplementHere");
		for (int i = 0;i< arr.Length; i++) {
			arr [i] = 0;
		}
	
	}
	void OnCollisionEnter2D(Collision2D col){
		/*if (start == 0) {
			Debug.Log (col.gameObject.name);
			Debug.Log (line);
			start = 1;
		}*/
		switch(col.gameObject.tag){
		case "move10":
			arr [0] = 1;
			GameObject Forward = Instantiate (blocks [0], parent.transform)as GameObject;
			Forward.gameObject.tag = line.ToString ();
			break;
		case "Backward":
			arr [1] = 1;	
			GameObject Backward = Instantiate (blocks [1], parent.transform)as GameObject;
			Backward.gameObject.tag = line.ToString ();
			break;
		}

	}/*
	void OnCollisionStay2D(Collision2D col){
		switch (col.gameObject.tag) {
		case "move10":
			arr [0] = 1;
			break;
		case "Backward":
			arr [1] = 1;
			break;
		}
	}*/
	void OnCollisionExit2D(Collision2D col){
		//start = 0;
		switch (col.gameObject.tag) {
		case "move10":
			arr [0] = 0;
			break;
		case "Backward":
			arr [1] = 0;	
			turn = 0;
			break;
		}
	}

}
