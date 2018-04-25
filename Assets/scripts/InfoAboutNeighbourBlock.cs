using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoAboutNeighbourBlock : Playermovement {
	[SerializeField]
	Transform CodeSection;
	int count;
	bool start=false;
	void Start (){
		StartCoroutine (WaitForSecond (0.5f));
	}
	void OnEnable(){
		StartCoroutine (WaitForSecond (0.5f));
	}
	IEnumerator WaitForSecond(float time){
		yield return new WaitForSeconds (time);
		if (CodeSection.childCount == 0) {
		} else {
			foreach (Transform child in CodeSection) {
				Debug.Log (child.name);
				if (child.name == "Forwardchild(Clone)") {
					count = 0;
					InvokeRepeating ("Forward",0.5f, 0.01f);
				}
				else if(child.name=="backchild(Clone)"){
					count = 0;
					InvokeRepeating ("Backward",0.5f, 0.01f);

				}
				yield return new WaitForSeconds (10.0f);
			}
		}

	}
	void Forward(){
		moveForward ();
		count++;
		if (count > 600) {
			CancelInvoke (methodName:"Forward");
		}
	}
	void Backward(){
		
		moveBackward ();
		count++;
		if (count > 600) {
			CancelInvoke (methodName:"Backward");
		}
	}

}

