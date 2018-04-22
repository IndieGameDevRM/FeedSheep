using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour {
	public GameObject[] finger;
	float timer=0f;
	bool pass=false;
	void Start () {
		finger [0].SetActive (true);
		finger [1].SetActive (false);
		}

	void Update () {
		timer += 0.1f;
		if (timer > 3f && pass==false) {
			finger [0].SetActive (false);
			finger [1].SetActive (true);
			pass = true;
		}if (timer > 6f) {
			finger [0].SetActive (true);
			finger [1].SetActive (false);
			timer = 0f;pass = false;
		}
	}
}