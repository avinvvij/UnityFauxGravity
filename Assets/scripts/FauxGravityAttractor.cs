using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour {

    public float gravity_factor = -10f;

    public void Attract(Transform body_transform)
    {
        Vector3 gravity_up = (body_transform.position - gameObject.transform.position).normalized;
        Vector3 body_up = body_transform.up;

        body_transform.gameObject.GetComponent<Rigidbody>().AddForce(gravity_factor * gravity_up);
        Quaternion targetRotation = Quaternion.FromToRotation(body_up, gravity_up) * body_transform.rotation; 
        body_transform.rotation = Quaternion.Slerp(body_transform.rotation , targetRotation , 50f * Time.deltaTime) ;
    }
}
