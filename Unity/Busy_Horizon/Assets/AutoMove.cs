using UnityEngine;
using System.Collections;


public class AutoMove : MonoBehaviour {
	
	public float rotOffset = 90f;
	public float rotMultiplier = 0f;

	float speedMin = 0.01f;
	float speedMax = 0.05f;
	float radiusMin = 100f;
	float radiusMax = 362f;
//	float offset = 0f;

	float randSpeed;
	float randRadius;
	float randOffset;
//	Quaternion rotationAngle;

	public GameObject frame;

	// Use this for initialization
	void Start () {
		randSpeed = Random.Range (speedMin, speedMax);
		randRadius = Random.Range (radiusMin, radiusMax);
		randOffset = Random.Range (0f, 360f);
		frame = transform.Find ("Line04").gameObject;
		Debug.Log (frame);
		Color RandomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
		frame.GetComponent<Renderer> ().material.color = RandomColor;
		frame.GetComponent<Renderer> ().material.SetColor("_EmmissionColor", RandomColor);

//
//		Transform[] allChildren = LevelParts.GetComponentsInChildren<Transform>();
//
//		foreach (Transform child in allChildren) {
//			if (child = "Line04"){
//				child.renderer.material.color = RandomColor;
//			}
//		}
	}
	
	// Update is called once per frame
	void Update () {
		float posX = Mathf.Sin (Time.time*randSpeed+randOffset) * randRadius;
		float posZ = Mathf.Cos (Time.time*randSpeed+randOffset) * randRadius;
		transform.position = new Vector3 (posX, 0, posZ);
//		rotationAngle.eulerAngles = new Vector3(0, (Mathf.Sin (Time.time* randSpeed+randOffset)*rotMultiplier)+rotOffset, 0);
//		transform.Rotate(0, Time.deltaTime * rotMultiplier, 0);
//		transform.position -= transform.right * (Time.deltaTime * rotMultiplier + randSpeed);
//		* randSpeed+randOffset
	}
}
