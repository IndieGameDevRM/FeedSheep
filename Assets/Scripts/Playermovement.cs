using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Playermovement :editor {
	Rigidbody player;

	public float speed = 100;
	[SerializeField]
	private float playermovementtimer=0f;
	void Start (){
		player = GetComponent<Rigidbody> ();
	}
	void Update(){
		moveForward ();
		moveBackward ();

	}
	void moveForward(){
		if (arr [0] == 1) {
			playermovementtimer += 0.1f;
			if (playermovementtimer <= 40) {
				if (turn >= 1) {
					transform.Rotate (0, 0, 180);
					turn = 0;
				}

				player.AddForce (0, 0, speed * Time.deltaTime);
			}
		} else {
			player.AddForce (0, 0, 0);
			playermovementtimer = 0f;
		}
	}
	void moveBackward(){
		if (arr [0] == 1) {
			playermovementtimer += 0.1f;
			if (playermovementtimer <= 40) {
				if (turn >= 1) {
					transform.Rotate (0, 0, 180);
					turn = 0;
				}

				player.AddForce (0, 0, speed * Time.deltaTime);
			}
		} else {
			player.AddForce (0, 0, 0);
			playermovementtimer = 0f;
		}
		if (arr [1] == 1) {
			if (turn < 1) {
				transform.Rotate(0, 0, 180);

			}
			player.AddForce (0, 0, -speed * Time.deltaTime);
			turn++;
		}
	}

}
