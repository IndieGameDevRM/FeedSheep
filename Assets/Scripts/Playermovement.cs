using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playermovement :linecollider {
	//[SerializeField]
	public Rigidbody player;
	public static float speed = 100;
    
    Vector3 Leftmovemement = new Vector3(0,0, -90);
	int _timer=0,_secondtimer=0,turn=1;

    void Start (){
		//player = GetComponent<Rigidbody> ();
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
            player.AddForce (this.transform.forward*speed*Time.deltaTime);
            //transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
	}
	public void moveBackward(){
		if (arr [1] == 1) {
            /*if (turn < 1) {
				transform.Rotate(0, 0, 180);
			}*/
            player.AddForce (-this.transform.forward * speed * Time.deltaTime);
            //	turn++;
            //transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }
	}
    public void Turnleft()
    {
       player.transform.Rotate(Vector3.up,-90);
    }

}
