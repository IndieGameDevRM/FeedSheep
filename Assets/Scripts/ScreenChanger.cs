using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScreenChanger : Playbutton {
	public GameObject poper;
	void Start(){
		//poper.SetActive (true);
	}
	public void ChangeScene(string SceneName){
		SceneManager.LoadScene (SceneName);
	}
	public void Next(string Scene){
		poper.SetActive (false);
		playButton ();
		DisableBlocks();
        SceneManager.LoadSceneAsync(Scene);
	}

}
