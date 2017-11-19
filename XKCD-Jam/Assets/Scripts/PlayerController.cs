using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float playerSpeed;
    public Rigidbody rb;
    public float rotateSpeed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
        //rotate character

        if(Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(Vector3.up, rotateSpeed);

        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(Vector3.up, -1 * rotateSpeed);

        }

        if (Input.GetAxis("Vertical") > 0)
        {
            Vector3 newGo = transform.forward.normalized * playerSpeed * .01f;
            transform.position = transform.position + newGo;

        }

        else
        {
            rb.velocity = Vector3.zero;

        }
        



    }
}
