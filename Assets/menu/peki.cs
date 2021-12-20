using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peki : MonoBehaviour {
	GameObject[] ch;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ch = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++) {
			ch [i] = transform.GetChild (i).gameObject;
			ch [i].SetActive (false);
		}

		ch [PlayerPrefs.GetInt ("inx")].SetActive (true);
		
	}
}
