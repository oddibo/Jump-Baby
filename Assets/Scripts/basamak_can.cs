using UnityEngine;
using System.Collections;

public class basamak_can : MonoBehaviour {

	public int Can;

	private Rigidbody rb;
	private Rigidbody rbplay;
	void Start()
	{
		rb = transform.parent.GetComponent<Rigidbody> ();
		rbplay = GameObject.Find ("PLAYER").GetComponent<Rigidbody> ();
		if (Can==3)
			transform.parent.gameObject.GetComponent<Renderer> ().material.color = Color.green;
		if (Can==2)
			transform.parent.gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
		if (Can==1) 
			transform.parent.gameObject.GetComponent<Renderer> ().material.color = Color.red;
	}
	void Update()
	{
		
		

	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (Can == 4)
				transform.parent.gameObject.GetComponent<Renderer> ().material.color = Color.green;
			else if (Can == 3) {
				StartCoroutine (cmfl ());
				transform.parent.gameObject.GetComponent<Renderer> ().material.color = Color.yellow;

			} else if (Can == 2) 
				transform.parent.gameObject.GetComponent<Renderer> ().material.color = Color.red;
			
				Can = Can - 1;
		
			
			if (Can==0) 
			{
				rb.isKinematic = false;
				StartCoroutine (cmfl ());

			}

			else if (Can==-1) 
			{

				rbplay.freezeRotation = false;

			}
		

		}
}

	IEnumerator cmfl()
	{



		yield return new WaitForSeconds (5);	
		Can = 3;
		transform.parent.gameObject.GetComponent<Renderer> ().material.color = Color.green;
		if (transform.tag=="red") {
			Can = 1;
			transform.parent.gameObject.GetComponent<Renderer> ().material.color = Color.red;
		}
		else if (transform.tag=="sari") {
			Can = 2;
			transform.parent.gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
		}

		rb.isKinematic = true;

	}
}
