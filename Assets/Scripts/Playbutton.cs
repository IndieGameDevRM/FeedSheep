using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playbutton : MonoBehaviour {
	
	[SerializeField]
	GameObject[] GameObjectTodisable;
	public void disableComponent (){

		for (int i = 0; i < GameObjectTodisable.Length; i++) {
			GameObjectTodisable [i].SetActive (false);
		}
		Debug.Log ("Stop");
	}
	public void enableallComponent (){
		for (int i = 0; i < GameObjectTodisable.Length; i++) {
			GameObjectTodisable [i].SetActive (true);
		}
	}
	void Start(){
		disableComponent ();
		GameObjectTodisable [3].SetActive (true);
	}
	public void playButton(){
		enableallComponent ();
		GameObjectTodisable [3].SetActive (false);
	}
	public void stopButton(){
		disableComponent ();
		GameObjectTodisable [3].SetActive (true);
	}

}
