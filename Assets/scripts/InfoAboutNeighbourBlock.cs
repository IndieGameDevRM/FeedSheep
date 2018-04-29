using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoAboutNeighbourBlock : Playermovement {
	[SerializeField]
	Transform CodeSection;
	int count = 0, number = 1;
	bool start=false;
	Vector2 direction;
	int line=0;
	void Start (){
		StartCoroutine (WaitForSecond (0.5f));
	}
	void OnEnable(){
		
		StartCoroutine (WaitForSecond (0.5f));
	}
	IEnumerator WaitForSecond(float time){
		yield return new WaitForSeconds (time);
		if (CodeSection.childCount == 0) {
		} 
		//foreach (Transform child in CodeSection)
		for(int i=0;i<CodeSection.childCount;i++){
				//	Debug.Log (child.name);
			Debug.Log (number);
			GameObject obj = GameObject.FindGameObjectWithTag (number.ToString());
			Debug.Log (obj.name);
			//print ("childname:" + child.name + ",tag:" + child.tag.ToString());
						if (obj.name == "Forwardchild(Clone)") {
							count = 0;
							InvokeRepeating ("Forward", 0.5f, 0.01f);
						} else if (obj.name == "backchild(Clone)") {
							count = 0;
							InvokeRepeating ("Backward", 0.5f, 0.01f);

						}
					yield return new WaitForSeconds (10.0f);
			number++;
					
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

