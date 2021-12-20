using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sec : MonoBehaviour {
	public Text text;
	 int index;
	
	void OnCollisionEnter(Collision other)
	{

		switch (other.gameObject.tag) 

		   {

		case "aslan":
			text.text = "ASLAN";
			index = 1;
			break;

		case "civciv":
			text.text = "CİVCİV";
			index = 2;
			break;

		case "tavsan":
			text.text = "PONÇİK";
			index = 3;
			break;

		case "robot":
			text.text = "ROBOKOP";
			index = 4;
			break;

		case "penguen":
			text.text = "PENGUEN";
			index = 5;
			break;

		case "kaplumbaga":
			text.text = "KAPLUMBAĞA";
			index = 6;
			break;

		case "buyucu":
			text.text = "BÜYÜCÜ";
			index = 7;
			break;

		case "kurba":
			text.text = "KURBA";
			index = 8;
			break;

		case "kopek":
			text.text = "KÖPEK";
			index = 9;
			break;

		case "uzayli":
			text.text = "UZAYLI";
			index = 10;
			break;

		case "ari":
			text.text = "ARI";
			index = 0;
			break;


		
		
		default:
			break;
		   }


	}

	public void secme()
	{
		PlayerPrefs.SetInt ("inx", index);
	


	}
	public void secmeX()
	{
		
			Application.LoadLevel (1);



	}
}
