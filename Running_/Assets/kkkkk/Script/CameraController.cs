using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public Camera[] cameras;
	//public Camera firstPersonCamera;
	//public Camera overheadCamera;

	void start(){
		cameras [0].gameObject.SetActive (true);
		Debug.Log ("Camera name:" + cameras [0].GetComponent<Camera>().name + "is now enabled");
	}
	void update(){
		if (Input.GetKeyDown (KeyCode.A)) {
			//ShowFirstPersonView ();
		}
		Debug.Log ("Camera name:" + cameras [0].GetComponent<Camera>().name + "is now enabled");
		Debug.Log ("lalll");
	}
//	public void ShowOverheadView() {
//		firstPersonCamera.enabled = false;
//		overheadCamera.enabled = true;
//	}
//
//	public void ShowFirstPersonView() {
//		firstPersonCamera.enabled = true;
//		overheadCamera.enabled = false;
//	}
}


