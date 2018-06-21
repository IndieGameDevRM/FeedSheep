using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ContinueScript : MonoBehaviour {
    public static string currentlevel = "level1"; 

	public ContinueScript(string c)
    {
        currentlevel = c;
    }
    public void Continuefromlevel()
    {
        SceneManager.LoadSceneAsync(currentlevel);
    }
}
