using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour {
	int count=0;
	[SerializeField]
	Behaviour point;
	void Start(){
		//poper = GameObject.Find ("LevelUP_Popper");
		point.enabled=false;
	}
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag=="sheep"){
			count++;
			Destroy(this.gameObject);
			point.enabled = true;
		}
	
	}
}
