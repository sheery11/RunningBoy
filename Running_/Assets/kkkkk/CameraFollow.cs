using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class CameraFollow : NetworkBehaviour {

	public float height = 1;//高度
	public float distance = 4;//距离
	//public float height = 2;//高度
	//public float distance = -4;//距离
	//public float rotationDamping = 0;//旋转阻尼
	//public float heightDamping = 0;//高度阻尼

	void Update ()
	{
		//isLocalPlayer是NetworkBehaviour的内置属性
		if (!isLocalPlayer) //如果不是本地客户端，就返回，不执行下面的操作
			return;	
		var campos  = Camera.main.transform;//相机位置
		var target  = this.transform;//目标位置变换
		//将相机置于角色位置
		campos.rotation = target.rotation;
		campos.position = target.position;
		//相机平移
		campos.Translate (Vector3.up * height);//y轴平移
		campos.Translate (Vector3.back * distance);//z轴平移
	}

	// Update is called once per frame
	/*void LateUpdate()
	{
		if (!isLocalPlayer) //如果不是本地客户端，就返回，不执行下面的操作
			return;
		var crmTrms  = Camera.main.transform;//相机位置
		var target   = this.transform;//位置变换
		// Calculate the current rotation angles
		var wantedRotationAngle = target.eulerAngles.y;
		var wantedHeight = target.position.y + height;

		var currentRotationAngle = crmTrms.eulerAngles.y;
		var currentHeight = crmTrms.position.y;

		// Damp the rotation around the y-axis//阻尼绕y轴的旋转（插值角度）
		currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

		// Damp the height
		currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

		// Convert the angle into a rotation//将角度转换为旋转
		var currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);//绕y轴旋转currentRotationAngle

		// Set the position of the camera on the x-z plane to://把相机的位置设置在x-z平面上:
		// distance meters behind the target//目标后的距离

		crmTrms.position = target.position;//将镜头的位置设置成对象的位置
		crmTrms.position -= currentRotation * Vector3.forward * distance;//

		// Set the height of the camera
		crmTrms.position = new Vector3(crmTrms.position.x ,currentHeight , crmTrms.position.z);

		// Always look at the target
		crmTrms.LookAt(target);
	}*/
}
