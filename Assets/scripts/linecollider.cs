using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linecollider : MonoBehaviour {
	public static int[] arr=new int[10];
	int turn=0;
	public int line=0;
	[SerializeField]
	GameObject play;
	public GameObject[] blocks;
	public GameObject parent;
	bool action=false;
    private inputfieldInput inp;
    private InputRight inpRight;
    private forloopinput linp;
    public static string Angle="";
    public static string Angletowardright = "";
    public static string times = "";
	void Start() {
        inp = FindObjectOfType<inputfieldInput>();
        linp = FindObjectOfType<forloopinput>();
        inpRight = FindObjectOfType<InputRight>();
		play = GameObject.Find ("play");
		//blocks [0] = GameObject.FindGameObjectWithTag ("move10");
		//blocks [1] = GameObject.FindGameObjectWithTag("Backward");
		parent = GameObject.Find ("CodeWillImplementHere");
		for (int i = 0;i< arr.Length; i++) {
			arr [i] = 0;
		}
	
	}
	void OnCollisionEnter2D(Collision2D col){
		switch(col.gameObject.tag){
		case "move10":

			arr [0] = 1;
			GameObject Forward = Instantiate (blocks [0], parent.transform)as GameObject;
			Forward.gameObject.tag = line.ToString ();
			break;
		case "Backward":
			arr [1] = 1;	
			GameObject Backward = Instantiate (blocks [1], parent.transform)as GameObject;
			Backward.gameObject.tag = line.ToString ();
			break;
        case "turn":
            Angle =inp.Message;
            Debug.Log("Rotation Angle:" + Angle);
            arr[2]= 1;
            GameObject Turn = Instantiate(blocks[2], parent.transform) as GameObject;
            Turn.gameObject.tag = line.ToString();
            break;
        case "ForLoop":
            times = linp.loopcount;
            Debug.Log("number of repeated loop:" + times);
            arr[3] = 1;
            GameObject Repeat = Instantiate(blocks[3], parent.transform) as GameObject;
            Repeat.gameObject.tag = line.ToString();
            break;
        case "turnRight":
             Angletowardright = inpRight.Message;
             arr[4] = 1;
             GameObject TurnRight = Instantiate(blocks[4], parent.transform) as GameObject;
             TurnRight.gameObject.tag = line.ToString();
             break;
        case "jump":
           GameObject Jump = Instantiate(blocks[5], parent.transform) as GameObject;
           Jump.gameObject.tag = line.ToString();
           break;
        }

    }
	void OnCollisionExit2D(Collision2D col){
		//start = 0;
		switch (col.gameObject.tag) {
		case "move10":
			arr [0] = 0;
			break;
		case "Backward":
			arr [1] = 0;	
			turn = 0;
			break;
        case "turn":
            Angle = inp.Message;
            arr[2] = 0;
            break;
        case "repeat4":
            arr[3] = 0;
            break;
        case "turnRight":
            Angletowardright = inpRight.Message;
            arr[4] = 0;
            break;
        }
  
	}
    public string Getangle()
    {
        return Angle;
    }
    public string GetAngleFromRight() {
        return Angletowardright;
    }
}
