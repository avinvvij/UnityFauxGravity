using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour {

    public FauxGravityAttractor attractor;
    private Transform mytransform;
    private Rigidbody myrigidbody;

	// Use this for initialization
	void Start () {
        myrigidbody = GetComponent<Rigidbody>();
        myrigidbody.useGravity = false;
        myrigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        mytransform = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
        attractor.Attract(mytransform);
	}
}
