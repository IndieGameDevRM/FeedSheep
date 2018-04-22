using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoringinfoAboutNeighbours:MonoBehaviour{
	string[] blocks=new string[10];
	int i=0;
	//clear all the blocks
	public StoringinfoAboutNeighbours(string a){
		blocks [i] = a;
		Debug.Log (i);
		Debug.Log (blocks [i]);
		i++;
	}

}
