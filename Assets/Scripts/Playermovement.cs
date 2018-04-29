using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playermovement :linecollider {
	//[SerializeField]
	public Rigidbody player;
	public float speed = 100;
	[SerializeField]
	GameObject Codequeue;

	int _timer=0,_secondtimer=0,turn=1;
	void Start (){
		player = GetComponent<Rigidbody> ();
	}
	void Update(){
		//transform.Rotate(0, 0, 1);
	}
	public void moveForward(){
		
			if (arr [0] == 1) {
				/*if (turn >= 1) {
					transform.Rotate (0, 0, 180);
					turn = 0;
				}*/
				player.AddForce (0, 0, speed * Time.deltaTime);
		}
	}
	public void moveBackward(){
		if (arr [1] == 1) {
			/*if (turn < 1) {
				transform.Rotate(0, 0, 180);
			}*/
			player.AddForce (0, 0, -speed * Time.deltaTime);
		//	turn++;
		}
	}

}
