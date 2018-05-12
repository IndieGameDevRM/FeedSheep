﻿using System;
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
        Debug.Log("TImes:" + times);
		if (CodeSection.childCount == 0) {
		}
        //foreach (Transform child in CodeSection)
        // Debug.Log(CodeSection.childCount);
        for (int i = 1; i < CodeSection.childCount+1;i++)
        {
            
            GameObject obj = GameObject.FindGameObjectWithTag(i.ToString());
                //  print("value of i:" + i);
                // Debug.Log(obj.name.ToString());
                print ("childname:" + obj.name + ",tag:" + obj.tag.ToString());
                if (obj.name == "Forwardchild(Clone)")
                {
                    Debug.Log("ya moving for");
                    count = 0;
                    InvokeRepeating("Forward", 0.5f, 0.01f);
                }else if (obj.name == "backchild(Clone)")
                {
                    Debug.Log("ya moving back");
                    count = 0;
                    InvokeRepeating("Backward", 0.5f, 0.01f);

                }
                else if (obj.name == "Turn(Clone)")
                {
                    Debug.Log("Turn");
                    TurnPlayer();
                }
                else if (obj.name == "RepeatChild(Clone)")
                {
                    //Debug.Log("Loop");
                    wasLoop = true;
                    //i = line;
                    //loopcounter++;
                    whereisloop = Int32.Parse(obj.tag.ToString());
                    print("loop is at line :" + whereisloop);
                }

                //forloop statement
                //but it will excuete after end
                 if (i == CodeSection.childCount)
                 {
                     Debug.Log("Yes it was loop");
                     if (wasLoop == true)
                     {
                         i = whereisloop;
                         loopcounter++;
                    if (loopcounter >= Int32.Parse(times)+1)
                         {
                             wasLoop = false;
                         }

                     }
                 }
                 //last time i update here
            yield return new WaitForSeconds(5.5f);
        }
    }
    void Forward()
    {
        moveForward();
        count++;
        if (count > 600)
        {
            CancelInvoke(methodName: "Forward");
        }
    }
    void Backward()
    {
        moveBackward();
        count++;
        if (count > 600)
        {
            CancelInvoke(methodName: "Backward");
        }
    }
   

}

