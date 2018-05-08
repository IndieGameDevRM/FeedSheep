using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkalleatencheckpoint : MonoBehaviour {
    [SerializeField]
    GameObject poper;
    private void Start()
    {
       
        poper.SetActive(false);
    }
    // Update is called once per frame
    void FixedUpdate () {
        if (transform.childCount == 0)
        {
            poper.SetActive(true);
        }
	}
}
