using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
	public AudioClip crashMusic;
	private AudioSource _audioSource;
	string sentence = "";
	string sentence_ = "";
	// Use this for initialization
	void Start () {
		_audioSource = this.gameObject.AddComponent<AudioSource> ();
	}
	
	// Update is called once per frame

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name.Contains ("stage_handrail")) {
			//ifCrashStage = true;
			_audioSource.clip = crashMusic;
			_audioSource.Play ();
			sentence_ = "系统提示：碰撞到障碍物，总分减1分！";
		} 
	}

	void OnCollisionExit(Collision other){
		if (other.gameObject.name.Contains ("stage_handrail")) {
			sentence_ = "";
		}
	}

	void Update () {
		if (Input.GetKey (KeyCode.Space)) {

		}
	}
	void OnGUI(){
		GUI.Label (new Rect (Screen.width / 2 - 130, Screen.height / 2 - 10, 350, 100), sentence+sentence_);
	}
}
