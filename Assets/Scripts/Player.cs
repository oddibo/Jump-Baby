using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {
	Rigidbody rb; 
	Rigidbody rbplay;
	private float hiz;

	public int HighSkor;
	public int count=0;
	private	bool cammove=false;
	private bool camfall = false;
	Vector3 ac;
	Vector3 ax;

	public Text skor;
	public Text HighSkorT;
	public Text skorMenu;
	public Text highSkorMenu;




	       GameObject[] ch;
	public GameObject cam;
	public GameObject panel;
	public GameObject panelKarakter;

	void Start () {
		ch = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++) {
			ch [i] = transform.GetChild (i).gameObject;
			ch [i].SetActive (false);
		}
		ch [PlayerPrefs.GetInt ("inx")].SetActive (true);

		panel.SetActive (false);
		ac = new Vector3 (0.2f, -0.17f, 0);
		rbplay = GameObject.Find ("PLAYER").GetComponent<Rigidbody> ();

		HighSkor = 0;
		rb = GetComponent<Rigidbody> ();	
		hiz = 3.3f;
		HighSkor = PlayerPrefs.GetInt ("hiskor");
	}

	void Update(){
		
		if (Input.GetKey("up")) {
			PlayerPrefs.DeleteAll();
		}
		if (count>HighSkor) {
			HighSkor = count;

			PlayerPrefs.SetInt ("hiskor", HighSkor);
			//Application.LoadLevel (0);
		}
		HighSkorT.text = "" + HighSkor;
		//Debug.Log (count);
		if (cammove) {
			cam.transform.position = Vector3.Lerp (cam.transform.position,ac, 1.0f*Time.deltaTime);
		}
		if (camfall) {
			cam.transform.position = Vector3.Lerp (cam.transform.position,ax, 3f*Time.deltaTime);
			StartCoroutine (cmfl ());
		}
		skor.text = ""+count;

	//	transform.position= Vector3.Lerp (transform.position,new Vector3(0.359f,1,-0.294f),0.4f * Time.deltaTime);;
	}
	
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "basamak" || other.gameObject.tag == "red" || other.gameObject.tag == "sari" )
		{
			
			StartCoroutine (jumpwait ());
			//rb.AddForce (Vector3.up*hiz*Time.deltaTime);
			if (!rbplay.freezeRotation) {

				ax = other.transform.position+ new Vector3 (0, 0.3f, 0);
				camfall = true;
				cammove = false;
			}
		}
	
			if (other.gameObject.tag == "ilkbasamak")
			{
			StartCoroutine (jumpwait ());
			if (count>=2) {
				//StartCoroutine (dead ());
				camfall=true;
				rbplay.freezeRotation = false;
				ax = transform.position;// + new Vector3 (0, -0.33f, 0);
				rb.velocity = new Vector3 (1.0f,hiz,0.0f);
			}
              }


	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "coin")
		{
			StartCoroutine (cmmv ());
			StartCoroutine(sayac (other.gameObject));
			coinPlus ();



        }

	}

	IEnumerator sayac(GameObject obj)
	{
		obj.SetActive (false);
		yield return new WaitForSeconds (6);
		obj.SetActive (true);
	}
	IEnumerator cmmv()
	{
		ac += new Vector3 (0, 0.29f, 0);
		cammove = true;
		yield return new WaitForSeconds (10);
		//
	}
	IEnumerator cmfl()
	{
		
		yield return new WaitForSeconds (1f);

		panel.SetActive (true);

		skorMenu.text = ""+count;
		highSkorMenu.text = ""+HighSkor;
		GameObject.Find ("camera").GetComponent<Platform_donme> ().enabled = false;
		//Application.LoadLevel (0);

	}
	IEnumerator jumpwait()
	{

		yield return new WaitForSeconds (0.01f);
		rb.velocity = new Vector3 (0.0f,hiz,0.0f);
	}

	void coinPlus()
	{
		count += 1;




	}

	public void button_click(){

		Application.LoadLevel (1);

	}
	public void button_click_select(){

		Application.LoadLevel (0);

	}
	public void carakter_click(){
		panel.SetActive (false);
		panelKarakter.SetActive (true);



	}public void karakter_back_click(){
		panel.SetActive (true);
		panelKarakter.SetActive (false);

	}


}
