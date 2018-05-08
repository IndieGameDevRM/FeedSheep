using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playermovement :linecollider {
	//[SerializeField]
	public GameObject player;
	public static float speed = 1;
    int _timer=0,_secondtimer=0,turn=1;
    
    void Start (){
        player = GameObject.Find("Sheep");
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
           // player.AddForce (this.transform.forward*speed*Time.deltaTime);
            player.transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
	}
	public void moveBackward(){
		if (arr [1] == 1) {
            /*if (turn < 1) {
				transform.Rotate(0, 0, 180);
			}*/
            // player.AddForce (-this.transform.forward * speed * Time.deltaTime);
            //	turn++;
            player.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
    }
    public void Turnleft()
    {
       player.transform.Rotate(0,0,90);
    }

}
