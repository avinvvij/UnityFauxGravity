using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float move_speed = 15f;
    Vector3 move_dir;
    int horizontal_factor = 0;
    int vertical_factor = 0;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        horizontal_factor = 0;
        vertical_factor = 0;
        if (Input.GetKeyDown(KeyCode.A))
        {
            horizontal_factor = -1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            horizontal_factor = 1;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            vertical_factor = 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            vertical_factor = -1;
        }
		move_dir = new Vector3(horizontal_factor, 0f ,vertical_factor).normalized; 
	}

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().position = GetComponent<Rigidbody>().position + (transform.TransformDirection(move_dir) * move_speed * Time.deltaTime);
    }
}
