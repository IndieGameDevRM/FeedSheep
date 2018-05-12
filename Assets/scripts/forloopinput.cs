using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forloopinput : MonoBehaviour {

    public string loopcount = "";
    public void setmessage(string n)
    {
        loopcount = n;
    }
    public void GetInput(string mess)
    {
        loopcount = mess;
        setmessage(mess);
        Debug.Log("You have Entered:" + loopcount+" Loop");

    }
}
