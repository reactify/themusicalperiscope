using UnityEngine;
using System.Collections;

public class AutoMove : MonoBehaviour {

	float speedMin = 0.01f;
	float speedMax = 0.05f;
	float radiusMin = 100f;
	float radiusMax = 362f;
	float offset = 0f;

	float randSpeed;
	float randRadius;
	float randOffset;
	Quaternion rotationAngle;

	// Use this for initialization
	void Start () {
		randSpeed = Random.Range (speedMin, speedMax);
		randRadius = Random.Range (radiusMin, radiusMax);
		randOffset = Random.Range (0f, 360f);
	}
	
	// Update is called once per frame
	void Update () {
		float posX = Mathf.Sin (Time.time*randSpeed+randOffset) * randRadius;
		float posZ = Mathf.Cos (Time.time*randSpeed+randOffset) * randRadius;
		transform.position = new Vector3 (posX, 0, posZ);
		rotationAngle.eulerAngles = new Vector3(0, Mathf.Sin (Time.time * randSpeed+randOffset)*Mathf.PI, 0);
		transform.rotation = rotationAngle;

	}
}
