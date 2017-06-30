using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMove : MonoBehaviour {
	float speed = 3.5f;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.forward *speed*Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			anim.SetBool ("ifTurnRight",true);
		}

	}
}
