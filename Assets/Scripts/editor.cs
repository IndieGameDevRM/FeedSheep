using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class editor : MonoBehaviour {
	[SerializeField]
	GameObject[] blocks;
	[SerializeField]
	GameObject parent;
	public static int[] arr=new int[10];
	public int turn=0;
	int once=0;
	void Start(){
		for (int i = 0;i< arr.Length; i++) {
			arr [i] = 0;
			once=0;
		}
	}
	void OnCollisionEnter2D(Collision2D col){
		switch(col.gameObject.tag){
		case "move10":
				arr [0] = 1;
				GameObject Forward = Instantiate (blocks [0], parent.transform)as GameObject;
				break;
			case "Backward":
				arr [1] = 1;	
				GameObject backward = Instantiate (blocks [1], parent.transform)as GameObject;
				break;
		}
	}
	void OnCollisionStay2D(Collision2D col){
		switch (col.gameObject.tag) {
		case "move10":
			arr [0] = 1;
			break;
		case "Backward":
			arr [1] = 1;	
			break;
			}
	}
	void OnCollisionExit2D(Collision2D col){
		switch (col.gameObject.tag) {
		case "move10":
			arr [0] = 0;
			once = 0;
			break;
		case "Backward":
			arr [1] = 0;	
			turn = 0;
			break;
		}
	}

	public int[] getarray(){
		return arr;
	}
}
