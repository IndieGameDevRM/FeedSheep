using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoadingScreenControl : MonoBehaviour {
	public GameObject loadingscreenobj;
	public Slider slider;
	public int scene;
	AsyncOperation aync;
	public void Start(){
		StartCoroutine (LoadingScreen ());
		
	}
	IEnumerator LoadingScreen(){
		loadingscreenobj.SetActive (true);
		aync = SceneManager.LoadSceneAsync (scene);
		aync.allowSceneActivation = false;

		while (aync.isDone == false) {
			float progress = Mathf.Clamp01 (aync.progress / .9f);
			slider.value = aync.progress;
			if (progress >= 0.8f) {
				slider.value = 1f;
				aync.allowSceneActivation = true;
			}
			yield return null;
		}
	}
}
