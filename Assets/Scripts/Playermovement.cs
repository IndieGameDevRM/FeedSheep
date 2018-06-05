using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playermovement :linecollider {
	//[SerializeField]
	public GameObject player;
	public static float speed = 1.2f;
    int _timer=0,_secondtimer=0,turn=1;
    string turningangle="";
    private Jump_Animation jmpP;
    void Start (){
        jmpP = FindObjectOfType<Jump_Animation>();
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
    public void TurnPlayer()
    {
        turningangle = Getangle();
        float a = float.Parse(turningangle);
       // Debug.Log("a value is:"+a);
       player.transform.Rotate(0,0,-a);
    }
    public void TurnRight()
    {
        turningangle =GetAngleFromRight();
        float ang = float.Parse(turningangle);
        Debug.Log("ang Value is:" + turningangle);
        player.transform.Rotate(0, 0, ang);
    }
    public void playerjump()
    {
        //for jump
    }
    
}
