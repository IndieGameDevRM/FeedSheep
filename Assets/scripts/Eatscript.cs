using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eatscript : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "sheep")
        {
            Destroy(transform.gameObject);
        }
    }
}
