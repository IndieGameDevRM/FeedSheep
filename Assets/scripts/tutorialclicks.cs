using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialclicks : MonoBehaviour {
	[SerializeField]
	GameObject[] tutorials;
	int pass=0;
	void Start(){
		tutorials [0].SetActive (true);
		for (int i = 1; i < tutorials.Length; i++) {
			tutorials [i].SetActive (false);
		}
		}
	public void disablecomponentone(){
		if (pass <1) {
			tutorials [0].SetActive (false);
			tutorials [1].SetActive (true);
			tutorials [2].SetActive (true);
		}
		pass++;

	}

	public void disableall(){
		for (int i = 0; i < tutorials.Length; i++) {
			tutorials [i].SetActive (false);
		}
	}
}
