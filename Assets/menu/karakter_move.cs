using UnityEngine;
using System.Collections;

public class karakter_move : MonoBehaviour {
	Vector3 scale=new Vector3(1.6f,1.6f,1.6f);
	float x;
	bool sag=true;
	bool sol=false;
	bool kuc=false;
	Vector3 kucuk;
	Vector3 buyuk;
	GameObject main;
	Vector3 mainaci;


	void Start()
	{
		

		buyuk = transform.localScale + new Vector3 (1.6f, 1.6f, 1.6f);
		kucuk = transform.localScale;

	}

	void Update () {
		
		if(kuc)
		transform.localScale =Vector3.Lerp (transform.localScale, kucuk, 4*Time.deltaTime);

		if (sag) {
			transform.Rotate(new Vector3(0,60f,0)*Time.deltaTime);
			if (transform.localRotation.y>0.7f) {
				sol = true;
				sag = false;
			}
		}

		if (sol) {
			transform.Rotate(new Vector3(0,-60f,0)*Time.deltaTime);
			if (transform.localRotation.y<-0.7f) {
				sag = true;
				sol = false;
			}
		}


	}


	void OnCollisionStay(Collision other)
	{
		if (other.gameObject.tag=="select") {
			transform.localScale =Vector3.Lerp (transform.localScale, scale, 4*Time.deltaTime);
			kuc = false;
		}

			
		}
	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag == "select")
			kuc = true;


	}
}