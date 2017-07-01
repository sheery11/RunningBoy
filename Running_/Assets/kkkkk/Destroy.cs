using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Destroy : NetworkBehaviour {

	public GameObject obj;
	/*float xx,yy,zz;  
	float px,py,pz;*/

	// Use this for initialization
	void Start () {
		/*xx = obj.GetComponent<Transform>().position.x;  
		yy = obj.GetComponent<Transform>().position.y;  
		zz = obj.GetComponent<Transform>().position.z;
		px = GameObject.Find ("Player1(Clone)").GetComponent<Transform>().position.x;
		py = GameObject.Find ("Player1(Clone)").GetComponent<Transform>().position.y;
		pz = GameObject.Find ("Player1(Clone)").GetComponent<Transform>().position.z;*/
		Debug.Log ("开始");
	}
	
	// Update is called once per frame
	void Update () {
		/*if (xx == px && yy == py && zz == pz) {
			Debug.Log ("碰撞人物");
			// 销毁当前游戏物体
			Destroy (this.gameObject);
		}*/
	}

	// 碰撞开始
	void OnCollisionEnter(Collision collision) {
		Debug.Log ("碰撞");
		//如果有人物生成
		if (collision.gameObject.name == "Player1(Clone)") {
			Debug.Log ("碰撞人物");
			// 销毁当前游戏物体
			Destroy (this.gameObject);
		}
	}

	// 碰撞结束
	void OnCollisionExit(Collision collision) {

	}

	// 碰撞持续中
	void OnCollisionStay(Collision collision) {

	}
}
