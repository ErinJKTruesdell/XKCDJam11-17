using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float playerSpeed;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 dir = Vector3.zero;

        if(Input.GetAxis("Horizontal") > 0)
        {
            dir.x += 1;

        }
		else if (Input.GetAxis("Horizontal") < 0)
        {
            dir.x -= 1;

        }

        if (Input.GetAxis("Vertical") > 0)
        {
            dir.z += 1;

        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            dir.z -= 1;
        }

        dir = dir.normalized * playerSpeed;
        rb.velocity = dir;
    }
}
