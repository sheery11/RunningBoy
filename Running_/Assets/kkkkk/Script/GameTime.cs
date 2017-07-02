using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour {
	GameObject obj;
	GameObject obj1;
	float timesinceCharacterCome;
	public float recordGameStartTime;
	bool ifHasPlayer = false;
	public Camera[] cameras;
	// Use this for initialization

	public bool ifText4Destroyed = false;
	void Start () {
		cameras [0].gameObject.SetActive (true);
		//Debug.Log ("Camera name:" + cameras [0].GetComponent<Camera>().name + "is now enabled");
	}

	// Update is called once per frame
	void Update () {
		GameObject text1 = GameObject.Find ("3");
		GameObject text2 = GameObject.Find ("2");
		GameObject text3 = GameObject.Find ("1");
		GameObject text4 = GameObject.Find ("Go");

		//if(obj.GetComponent<MenuSelect> ().TimeCount == 165 || obj1.GetComponent<Startmenu>().TimeCount == 165)text3.transform.localScale *= 0.0f;

		//Debug.Log (Time.time);

		if (GameObject.Find ("Player1(Clone)")) {
			//	ifHasPlayer = true;
		}

		if (ifHasPlayer)
			timesinceCharacterCome+=0.1f;

		//Debug.Log ("timesinceCharacterCome:" + (int)timesinceCharacterCome);

		if ((int)timesinceCharacterCome == 4) {
			MeshRenderer[] marr = text1.GetComponentsInChildren<MeshRenderer> (true);
			foreach (MeshRenderer m in marr) {
				m.enabled = true;
			}
			//Debug.Log ("3出现");
		}

		if ((int)timesinceCharacterCome == 8) {

			text1.transform.localScale *= 0.0f;
		}

		//	if(obj.GetComponent<MenuSelect> ().TimeCount == 65 || obj1.GetComponent<Startmenu>().TimeCount == 65)text1.transform.localScale *= 0.0f;

		if ((int)timesinceCharacterCome == 12) {
			MeshRenderer[] marr = text2.GetComponentsInChildren<MeshRenderer> (true);
			foreach (MeshRenderer m in marr) {
				m.enabled = true;
			}
			//Debug.Log ("2出现");
		}


		if ((int)timesinceCharacterCome == 16) {

			text2.transform.localScale *= 0.0f;
		}


		if ((int)timesinceCharacterCome == 20)  {
			MeshRenderer[] marr = text3.GetComponentsInChildren<MeshRenderer> (true);
			foreach (MeshRenderer m in marr) {
				m.enabled = true;
			}
			//Debug.Log ("1出现");
		}

		if ((int)timesinceCharacterCome == 24) {

			text3.transform.localScale *= 0.0f;
		}


		if ((int)timesinceCharacterCome == 28)  {
			MeshRenderer[] marr = text4.GetComponentsInChildren<MeshRenderer> (true);
			foreach (MeshRenderer m in marr) {
				m.enabled = true;
			}
		}

		if ((int)timesinceCharacterCome == 32) {

			text4.transform.localScale *= 0.0f;
			ifText4Destroyed = true;
		}



		if (GameObject.Find("Player1(Clone)")&&!ifText4Destroyed) {
			cameras[0].gameObject.SetActive (false);
			cameras[1].gameObject.SetActive (true);
		}


		if (GameObject.Find ("Player1(Clone)") && ifText4Destroyed) {  //如果有玩家并且Go已经消失 说明游戏要开始计时
			//cameras[0].gameObject.SetActive (false);
			cameras[1].gameObject.SetActive (false);
			cameras[2].gameObject.SetActive (true);
			GameObject.Find ("Player1(Clone)").AddComponent<CameraFollow>();
			recordGameStartTime+=0.017f;
		}
		Debug.Log ("游戏进行了"+(int)recordGameStartTime+"秒");
	}

	void OnCollisionEnter(Collision collision){  //已经站在地上了
		if (collision.gameObject.name=="Player1(Clone)") {
			//	ifCrashStage = true;
			//Debug.Log("在地上");
			ifHasPlayer = true;
			//timesinceCharacterCome++;
		} 
	}
}
