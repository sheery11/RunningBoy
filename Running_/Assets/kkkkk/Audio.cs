using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
	public AudioClip crashMusic;
	private AudioSource _audioSource;
	// Use this for initialization
	void Start () {
		_audioSource = this.gameObject.AddComponent<AudioSource> ();
	}
	
	// Update is called once per frame

	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			
		}



	}
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name.Contains ("stage_handrail")) {
			//ifCrashStage = true;
			_audioSource.clip = crashMusic;
			_audioSource.Play ();
		}
	}
}
