using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoAboutNeighbourBlock : MonoBehaviour {
	//Vector2 direction;
	[SerializeField]
	Transform CodeSection;
	void Update() {
		if (CodeSection.childCount == 0) {
		} else {
			foreach (Transform child in CodeSection) {
				print (child.name);
				if (child.name == "Forwardchild(Clone)") {
					print ("MoveForward");
				}  
				if(child.name=="backwardchild(Clone)"){
					print ("MoveBackward");
				}
			}
		}
	}
}

