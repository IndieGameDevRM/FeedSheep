using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playermovement :linecollider {
	//[SerializeField]
	public GameObject player;
	public static float speed = 1.2f;
    //for windows speed must be 1.2f;
    int _timer=0,_secondtimer=0,turn=1;
    string turningangle="";
    private Jump_Animation jmpP;
    Animator anim;
    public static bool ifpermission = false;
    void Start (){
        anim = GetComponent<Animator>();
        jmpP = FindObjectOfType<Jump_Animation>();
        player = GameObject.Find("Sheep");
		//player = GetComponent<Rigidbody> ();
	}
	
	public void moveForward(){
		
			/*if (turn >= 1) {
                transform.Rotate (0, 0, 180);
                turn = 0;
            }*/
           // player.AddForce (this.transform.forward*speed*Time.deltaTime);
            player.transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            
	}
	public void moveBackward(){
		    /*if (turn < 1) {
				transform.Rotate(0, 0, 180);
			}*/
            // player.AddForce (-this.transform.forward * speed * Time.deltaTime);
            //	turn++;
            player.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
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
        player.GetComponent<Animator>().SetBool("jump", true);
        //for jump
        
    }
    public void OnCollisionEnter(Collision collision)
    {   string mssg = GetCodition();
       
        if (collision.gameObject.tag == "iswall")
        {
            Debug.Log("yes collision is happing with wall");
            ifpermission = true;
        }
    }

}
