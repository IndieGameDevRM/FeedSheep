using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playbutton : MonoBehaviour {
	
	[SerializeField]
	GameObject[] GameObjectTodisable;
	//[SerializeField]
	//Behaviour Component;
	public void disableComponent (){

		for (int i = 0; i < GameObjectTodisable.Length; i++) {
			GameObjectTodisable [i].SetActive (false);
		}
		//Component.enabled = false;
	}
	public void enableallComponent (){
		for (int i = 0; i < GameObjectTodisable.Length; i++) {
			GameObjectTodisable [i].SetActive (true);
		}
		//Component.enabled = true;
	}
	void Start(){
		disableComponent ();
		//Component.enabled = false;
		GameObjectTodisable [3].SetActive (true);
	}
	public void playButton(){
		enableallComponent ();

		GameObjectTodisable [3].SetActive (false);
		GameObjectTodisable [4].SetActive (false);
	}
	public void stopButton(){
		disableComponent ();
		GameObjectTodisable [3].SetActive (true);

	}
	public void DisableBlocks(){
		//Component.enabled = false;
		GameObjectTodisable [0].SetActive (false);
		GameObjectTodisable [1].SetActive (false);
		GameObjectTodisable [2].SetActive (false);
		GameObjectTodisable [3].SetActive (true);
	}

}
