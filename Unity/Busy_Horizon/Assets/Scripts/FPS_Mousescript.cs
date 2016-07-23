using UnityEngine;
using System.Collections;

public class FPS_Mousescript : MonoBehaviour {

	public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
	public RotationAxes axes = RotationAxes.MouseXAndY;
	public float sensitivityX = 15F;
	public float sensitivityY = 15F;
	public float minimumX = -360F;
	public float maximumX = 360F;
	public float minimumY = -60F;
	public float maximumY = 60F;
	float rotationY = 0F;
	float rotationX = 0F;
	float multiplier = 1F;

	void Update ()
	{
	//	if (axes == RotationAxes.MouseXAndY)
	//	{
	//		float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
	//
	//		rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
	//		rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
	//
	//		transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
	//	}
	//	else if (axes == RotationAxes.MouseX)
	//	{
	//		transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
	//	}
	//	else
	//	{
	//		rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
	//		rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
	//
	//		transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
		//	}

		multiplier = 1f;

		if (Input.GetKey (KeyCode.LeftShift)) {
			multiplier = 3f;
		}

		if (Input.GetKey(KeyCode.A)) 
		{
			rotationX -= 0.4f * multiplier;
		}
		if (Input.GetKey(KeyCode.D)) 
		{
			rotationX += 0.4f * multiplier;
		}
		if (Input.GetKey(KeyCode.W)) 
		{
			rotationY -= 0.4f * multiplier;
			rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
		}
		if (Input.GetKey(KeyCode.S)) 
		{
			rotationY += 0.4f * multiplier;
			rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
		}
		if (Input.GetKey(KeyCode.E)) 
		{
			Camera.main.fieldOfView = Mathf.Clamp (Camera.main.fieldOfView - 1f, 22, 60);
		}
		if (Input.GetKey(KeyCode.Q)) 
		{
			Camera.main.fieldOfView = Mathf.Clamp (Camera.main.fieldOfView + 1f, 22, 60);
		}
		transform.localEulerAngles = new Vector3(rotationY, rotationX, 0);
	}

	void Start ()
	{
		// Make the rigid body not change rotation
		if (GetComponent<Rigidbody>())
			GetComponent<Rigidbody>().freezeRotation = true;
	}

}