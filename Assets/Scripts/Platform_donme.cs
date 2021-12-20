using UnityEngine;
using System.Collections;

public class Platform_donme : MonoBehaviour {

	bool click=false;
	public GameObject platform;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			click = true;
		}
		if (Input.GetMouseButtonUp(0)) {
			click = false;
		}
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast(ray, out hit)) {
			if (hit.collider.gameObject.tag =="sag") {
				
				if (click)
				platform.transform.Rotate (new Vector3 (0, 130, 0) * Time.deltaTime);

			}
			if (hit.collider.gameObject.tag =="sol") {
				
				if (click)
					platform.transform.Rotate (new Vector3 (0, -130, 0) * Time.deltaTime);

			}
		}
	}

}
