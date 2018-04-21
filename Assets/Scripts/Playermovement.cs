using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Playermovement :editor {
	Rigidbody player;
	public float speed = 100;
	public GameObject poper;
	void Start (){
		poper.SetActive (false);
		player = GetComponent<Rigidbody> ();
	}
	void Update(){
		
		if (arr [0] == 1) {
			player.AddForce (0, 0, speed * Time.deltaTime);
		} else {
			player.AddForce (0, 0, 0);
		}
	}
	void OnCollisionStay(Collision coll) {
		if (coll.gameObject.tag == "levelup") {
			arr [0] = 0;
			StartCoroutine ("waitforsecond");
			Debug.Log ("SceneLoadedAgain");
			//SceneManager.LoadScene ("test");
			poper.SetActive (true);
		}
	}
	IEnumerator waitforsecond(){
		yield return new WaitForSeconds (3.0f);
	}
}
