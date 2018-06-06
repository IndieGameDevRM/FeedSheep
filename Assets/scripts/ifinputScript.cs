using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifinputScript : MonoBehaviour {

    public string Message = "";
    public void setmessage(string n)
    {
        Message = n;
    }
    public void GetInput(string mess)
    {
        Message = mess;
        setmessage(mess);
        Debug.Log("You have Entered:" + Message);

    }
}
