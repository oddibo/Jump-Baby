using UnityEngine;
using System.Collections;

public class cevirme : MonoBehaviour {
	 Touch currentTouc;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentTouc = Input.GetTouch (0);
		
		if (Input.touchCount > 0)
		{
			Vector2 v2 = currentTouc.deltaPosition;
			Vector3 v3 = new Vector3(0.0f, v2.x, 0.0f);
			transform.Rotate(v3 * Time.deltaTime * (-1) * 2f);
		}
		//if(Input.GetMouseButton(0))
		


	}
}
