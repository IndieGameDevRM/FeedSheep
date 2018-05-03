using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoAboutNeighbourBlock : Playermovement {
	[SerializeField]
	Transform CodeSection;
	int count = 0, number = 1;
	bool start=false;
	Vector2 direction;
	int line=0;


    //loop counter
    int loopcounter=0;
	void Start (){
		StartCoroutine (WaitForSecond (0.5f));
	}
	void OnEnable(){
       
		StartCoroutine (WaitForSecond (0.5f));
	}
	IEnumerator WaitForSecond(float time){
		yield return new WaitForSeconds (time);
		if (CodeSection.childCount == 0) {
		}
        //foreach (Transform child in CodeSection)
        Debug.Log(CodeSection.childCount);
		for(int i=0;i<CodeSection.childCount;i++){

            //Debug.Log (child.name);
            print("number;"+number);
            try
            {
                GameObject obj = GameObject.FindGameObjectWithTag(number.ToString());
                Debug.Log(obj.name.ToString());
                //print ("childname:" + obj.name + ",tag:" + obj.tag.ToString());
                if (obj.name == "Forwardchild(Clone)")
                {
                    count = 0;
                    InvokeRepeating("Forward", 0.5f, 0.01f);
                }
                else if (obj.name == "backchild(Clone)")
                {
                    count = 0;
                    InvokeRepeating("Backward", 0.5f, 0.01f);

                }
                else if (obj.name == "Turn(Clone)")
                {
                    //Debug.Log("Turn");
                    Turnleft();
                }else if(obj.name == "Repeat(Clone)")
                {
                    Debug.Log("Loop");
                    //i = line;
                    //loopcounter++;
                }
            }
            catch(NullReferenceException e)
            {

            }
            yield return new WaitForSeconds(6.0f);
                number++;
            
		}
	}
	void Forward(){
		moveForward ();
		count++;
		if (count > 600) {
			CancelInvoke (methodName:"Forward");
		}
	}
	void Backward(){
		moveBackward ();
		count++;
		if (count > 600) {
			CancelInvoke (methodName:"Backward");
		}
	}
    void Turn()
    {
        Turnleft();
    }
  
}

