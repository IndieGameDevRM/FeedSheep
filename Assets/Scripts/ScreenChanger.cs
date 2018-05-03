using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScreenChanger : Playbutton {
	public GameObject[] cam;
	public GameObject poper;
	public GameObject[] spawingpoint;
	public GameObject[] obj;
	public GameObject sheep;
	void Start(){
		//poper.SetActive (true);
	}
	public void ChangeScene(string SceneName){
		SceneManager.LoadScene (SceneName);
	}
	public void Next(){
		cam[0].SetActive(false);
		cam [1].SetActive (true);
		sheep.transform.position = spawingpoint[0].transform.transform.position;
		//obj [0].transform.position = spawingpoint [1].transform.position;
		poper.SetActive (false);
		playButton ();
		DisableBlocks();
	}

}
