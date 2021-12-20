using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_script : MonoBehaviour {
	private Vector3 targetAngle = new Vector3 (25f, 238.5f, 0f);
	private Vector3 currentAngle;
	float speed=2f;
	// Use this for initialization
	void Start () {
		

		currentAngle = transform.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		
		currentAngle = new Vector3 (Mathf.LerpAngle (currentAngle.x, targetAngle.x, speed*Time.deltaTime), Mathf.LerpAngle (currentAngle.y, targetAngle.y, speed*Time.deltaTime), Mathf.LerpAngle (currentAngle.z, targetAngle.z, speed*Time.deltaTime));
		transform.eulerAngles = currentAngle;
	}

	public void CRBak()
	{
		targetAngle = new Vector3 (25f, -180f, 0f);
	}

	public void MNBak()
	{
		targetAngle = new Vector3 (25f, 238.5f, 0f);
	}
}
