using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    public float JumpHeight;
    public bool Grounded;

    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        Grounded = true;
    }

	void Update ()
    {		
        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            GetComponent<Rigidbody>().AddForce(transform.up * JumpHeight, ForceMode.Impulse);
            Grounded = false;
        }
	}
}
