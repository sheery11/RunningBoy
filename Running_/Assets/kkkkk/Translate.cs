using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Translate : NetworkBehaviour {
//	public bool ifCrashStage = false;
	//float speed = 3.5f;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.forward *speed*Time.deltaTime);
		}*/
//		if (Input.GetKey (KeyCode.A)) {
//			anim.SetBool ("ifTurnRight",true);
//		}
//
//		if (Input.GetKey (KeyCode.S)) {
//			anim.SetBool ("Crouch", true);
//		}

	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name.Contains ("stage_handrail")) {
			//ifCrashStage = true;

		}
	}
}
