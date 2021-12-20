using UnityEngine;
using System.Collections;
using Random=UnityEngine.Random;

public class platform : MonoBehaviour {
	
	public GameObject[] Basamak;

	public GameObject[] prefabBasamak;
	GameObject obj;

	float yL=23;
	float py=0.37f;
	int bassay;
	int x ;
	bool basOn=true;
	bool basamakOn=false;

	int deger=4;
	int i = 0;
	int random;
	int basdeger;
	int r;


	

	

	void Update () {
		
		if (GameObject.Find ("PLAYER").GetComponent<Player> ().count == deger) {
			StartCoroutine (cmfl ());
			deger++;
	   }
		if (basOn) {
			basamakSetup ();
			basOn = false;
		}

		else if (basamakOn) {
			bsmkinf ();
			basamakOn = false;


		}

	
	}


	void basamakSetup()
	{
		for (int i = 0; i <20; i++) {
			r = Random.Range (0, 6);
			if (r==0) {
				basdeger = 0;
			}
			if (r==1 || r==2) {
				basdeger=2;
			}
			if (r==3 || r==4 || r==5) {
				basdeger=1;
			}
			obj=  Instantiate (prefabBasamak[basdeger], new Vector3(0,0,0),Quaternion.identity) as GameObject;
			obj.transform.parent = gameObject.transform;
			//Debug.Log("y"+y);
			if (i<=20) {
				
			}
		}
		
	Basamak = new GameObject[transform.childCount];
	for (int i = 0; i <transform.childCount; i++) {
			
		Basamak [i] = transform.GetChild (i).gameObject;
	}
	for (int i = 4; i <transform.childCount; i++) {
			random = Random.Range (0,8);
			if (random==0) {
				yL += 50;
			}
			else if (random==1) {
				yL += 50;
			}
				if (random==2) {
				yL += 30;
			}
			else if (random==3) {
				yL += -30;
			}
			 else if (random==4) {
				yL += -55;
			}
			 	else if (random==5) {
				yL += 35;
			}
			else if (random==6) {
				yL += 40;
			}
			else  if (random==7) {
				yL += -40;
			}

		
		Basamak [i].transform.localRotation = Quaternion.Euler (0, yL, 0);
			py += 0.29f;
		Basamak [i].transform.position = new Vector3 (0, py, 0);
		

	}
}

	void bsmkinf(){
		
		i++;
		if (i==transform.childCount)
			i = 0;
		
		random = Random.Range (0,6);
		if (random==1) {
			yL += 50;
		}
		if (random==2) {
			yL += 50;
		}
		if (random==0) {
			yL += 30;
		}
		if (random==3) {
			yL += -30;
		}
		if (random==4) {
			yL += -40;
		}
		if (random==5) {
			yL += 40;
		}
			
	Basamak [i].transform.localRotation = Quaternion.Euler (0, yL, 0);
	py += 0.29f;
	Basamak [i].transform.position = new Vector3 (0, py, 0);
		Basamak [i].transform.GetChild (0).gameObject.transform.localPosition = new Vector3 (0.427f, 0, 0);
		Basamak [i].transform.GetChild (0).gameObject.transform.localRotation = Quaternion.Euler (0, 0, 0);
		Basamak [i].transform.GetChild (0).gameObject.GetComponent<Rigidbody> ().isKinematic = true;


	}
	IEnumerator cmfl()
	{
		

	
			yield return new WaitForSeconds (1);	
		basamakOn = true;

		

	}


}

