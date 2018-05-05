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

    //For loop parameter
    bool wasLoop = false;
    int whereisloop = 0;
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
       // Debug.Log(CodeSection.childCount);
		for(int i=0;i<CodeSection.childCount;){

            //Debug.Log (child.name);
            //print("number;"+number);
            try
            {
                //print(number);
                GameObject obj = GameObject.FindGameObjectWithTag(number.ToString());
              //  print("value of i:" + i);
               // Debug.Log(obj.name.ToString());
                //print ("childname:" + obj.name + ",tag:" + obj.tag.ToString());
                if (obj.name == "Forwardchild(Clone)")
                {
                    i++;
                    //Debug.Log("ya moving forward");
                    number++;
                    count = 0;
                    InvokeRepeating("Forward", 0.5f, 0.01f);
                }
                else if (obj.name == "backchild(Clone)")
                {
                    i++;
                    number++;
                    count = 0;
                    InvokeRepeating("Backward", 0.5f, 0.01f);

                }
                else if (obj.name == "Turn(Clone)")
                {
                    i++;
                  //  Debug.Log("ya turning");
                    number++;
                    Debug.Log("Turn");
                    //InvokeRepeating("Forward", 0.5f, 0.01f);
                    Turnleft();
                }else if(obj.name == "Repeat(Clone)")
                {
                    i++;
                    number++;
                    //Debug.Log("Loop");
                    wasLoop = true;
                    //i = line;
                    //loopcounter++;
                    whereisloop = Int32.Parse(obj.tag.ToString());
                    print("loop is at line :" +whereisloop);
                }

                //forloop statement
                //but it will excuete after end
                int c = CodeSection.childCount - 1;
                print("value of I:" + i + "childcount:" +c);
                if (i == CodeSection.childCount - 1)
                {
                    Debug.Log("Yes it was loop");
                    if (wasLoop == true)
                    {
                        i = whereisloop;
                        number = whereisloop + 1;
                        loopcounter++;
                        if (loopcounter >= 4)
                        {
                            wasLoop = false;
                        }
                      
                    }
                }
            }
            catch(NullReferenceException e)
            {

            }
            yield return new WaitForSeconds(6.0f);
               
            
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

