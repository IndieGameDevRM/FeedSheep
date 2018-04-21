using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Jump_Animation : MonoBehaviour {
	public Rigidbody player;
	private float speed=0;
	private float timer=0.0f;
	void Start(){
		player = GetComponent<Rigidbody> ();
	}
	void FixedUpdate () {
		timer += 0.1f;
		jump ();
	}
	void jump(){
		if (timer >= 3) {
			player.velocity = new Vector3 (0,3,0);

			timer = 0f;
		}
	}

}
