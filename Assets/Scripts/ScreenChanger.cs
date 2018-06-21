using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScreenChanger : Playbutton {
	public GameObject poper;
    private ContinueScript con;
	void Start(){
        con = FindObjectOfType<ContinueScript>();
		//poper.SetActive (true);
	}
	public void Next(string Scene){
		poper.SetActive (false);
		playButton ();
		DisableBlocks();
        con = new ContinueScript(Scene);
        SceneManager.LoadSceneAsync(Scene);
	}

}
