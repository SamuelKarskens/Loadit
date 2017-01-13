using UnityEngine;
using System.Collections;

public class createcubetest : MonoBehaviour {

	// Use this for initialization
	public string myvariable;
	public float length;
	public float newLength;
	public string lengteobject;
	public string breedteobject;
	public string hoogteobject;
	public float newBreedte;
	public float breedte;
	public float newHoogte;
	public float hoogte;
	public int nummervoor = 0;
	public int nummertje = 0;
	public int trans;
	public string sizeobject;
	public float breederbij;
	public float newbreederbij;
	public float afstandbreed = 0;
	public float newsizeobject;
	public float newensize;
	public string sizenewobject;
	public float newsizenewobject;
	public float newensizeen;
	public float newensizeennew;
	public float getalletje = 2;
	public float volgendegetalletje;
	public float newvolggetalletje;
	public string volggetalletje;
	public float eindelijkegetal;
	public float voorgetal = 0;
	public string halfvancubus;
	public float newhalfvancubus;
	public float newhalfnewvancubus;
	public float supernewhalfnewvancubus;
	public int testvariable = 0;
	public float hoogteerbij = 0;
	public float lengteerbij = 0;
	public int nummervancubus = 0;
	public float lengteerbijvanfunctie = 0;
	public int runonetime = 0;
	void Start () {
		//myvariable = PlayerPrefs.GetString("saveNom");
		//if (float.TryParse(myvariable, out newLength))
			//{
			//length = newLength;

			//}



		//Debug.Log (nummer);

		//while (getalletje <= trans) {

	}
	public void plusje (){
		//nummertje = PlayerPrefs.GetInt("nummertje");
		// stap 3 gedeelte hier neemt hij alle cubussen tussen de eerste en laatste en neemt de som van al die cubussen hun afstand
		while (getalletje <= trans) {
			volggetalletje = PlayerPrefs.GetString ("Breedte_" + getalletje);
			if (float.TryParse (volggetalletje, out newvolggetalletje)) {
				volgendegetalletje = newvolggetalletje;
			}
			eindelijkegetal = voorgetal + volgendegetalletje; 
			getalletje++; 
			Debug.Log(getalletje);  
		}
		//PlayerPrefs.SetInt("nummertje", nummertje);

	}
	public void afstandhouden (){
	//	if (breederbij >= 80 + newensizeennew) {

		//	breederbij = 0;
		//	lengteerbij = 20;



		//}
		getalletje = 2;
		nummervoor = PlayerPrefs.GetInt ("nummer");
		//nummervancubus was vroeger nummertje
		int trans = nummervancubus - 1;
		Debug.Log ("dit is het nummertje" + nummertje); 
		Debug.Log ("dit is het trans" + trans); 

		//stap 1 neemnt de breedte van de eerste cubus
		halfvancubus = PlayerPrefs.GetString ("Breedte_1");
			if (float.TryParse (halfvancubus, out newhalfvancubus)) {
				newhalfnewvancubus = newhalfvancubus;
			}


		// als er maar 1 cubus is dan is de afstand om bij de afstand op te tellen 0
		if (trans == 0) {
			breederbij = newhalfnewvancubus / 2;
			hoogteerbij = newhalfnewvancubus / 2;
			//lengteerbij = 0 - newhalfnewvancubus / 2 - lengteerbijvanfunctie;
		}

		// anders roep je van alle cubussen tussen het eerste en laatste cubusje de breedte op.
		// en voeg je die toe aan de totale breedte
		else {
			
		Debug.Log (trans);  
		//sizeobject = PlayerPrefs.GetString ("Breedte_" + trans);
		//if (float.TryParse (sizeobject, out newsizeobject)) {
			//newensize = newsizeobject;
		//}
			//getalletje >= 2 && 
			while (getalletje >= 2 && getalletje <= trans) {
				Debug.Log ("Start van while loop"); 
				volggetalletje = PlayerPrefs.GetString ("Breedte_" + getalletje);
				if (float.TryParse (volggetalletje, out newvolggetalletje)) {
					volgendegetalletje = newvolggetalletje;
				}
				eindelijkegetal = eindelijkegetal + volgendegetalletje;
				getalletje++; 

				}
			 

			Debug.Log("Dit is het getalletje van de while loop aan het einden" + getalletje);  

			while( testvariable <= 10){
				Debug.Log( "dit is het nummer" + testvariable);
				testvariable++; 
			}






			//stap 1 neemnt de breedte van de eerste cubus
			halfvancubus = PlayerPrefs.GetString ("Breedte_1");
			if (float.TryParse (halfvancubus, out newhalfvancubus)) {
				newhalfnewvancubus = newhalfvancubus;
			}

		// stap 2 neem de breedte van de laatste cubus
			sizenewobject = PlayerPrefs.GetString ("Breedte_" + nummertje);  
			if (float.TryParse (sizenewobject, out newsizenewobject)) {
				newensizeen = newsizenewobject;

			}
			supernewhalfnewvancubus = newhalfnewvancubus / 2; 
			newensizeennew = newensizeen / 2; 
			Debug.Log (supernewhalfnewvancubus);
			Debug.Log (newensizeennew);
			Debug.Log (eindelijkegetal);
			breederbij = supernewhalfnewvancubus + supernewhalfnewvancubus + newensizeennew + eindelijkegetal;
			eindelijkegetal = 0;

			hoogteerbij = newensizeennew;
			//deze lengte moet er nog bij later
			//lengteerbij = 0 - newensizeennew - lengteerbijvanfunctie;
		}
		//if (float.TryParse(breederbij, out newbreederbij))
		//{
			//afstandbreed = newbreederbij;

		//}

	}
	public void veranderzpositie(){

		//if (breederbij > 80) {
		//	lengteerbij = newensizeennew;



		//}


	}


	public void loaddata(){
		nummertje++;
		nummervancubus++;
		//waar nummer vancubus staat hieronder was vroeger nummertje
		lengteobject = PlayerPrefs.GetString("lengte_" + nummertje );
		breedteobject = PlayerPrefs.GetString ("Breedte_" + nummertje );
		hoogteobject = PlayerPrefs.GetString ("Hoogte_" + nummertje );
		if (float.TryParse(breedteobject, out newBreedte))
		{
			breedte = newBreedte;

		}


		if (float.TryParse(hoogteobject, out newHoogte))
		{
			hoogte = newHoogte;

		}



		if (float.TryParse(lengteobject, out newLength))
		{
			length = newLength;

		}

	}

	public void createcubussen(){
		//nummertje = PlayerPrefs.GetInt ("nummertje");  
		//nummertje++;
		//Debug.Log (nummertje); 
		//PlayerPrefs.SetInt("nummertje", nummertje);

		if (breederbij >= 120 && runonetime <= 1) {
			breederbij = 0;
			nummervancubus = 0;
			Debug.Log("Hoi" + breederbij);
			lengteerbij = 0 - newensizeennew - 20 -30;
			lengteerbijvanfunctie = -20;
			runonetime++;
		}


		//lengteerbij = 0 - newensizeennew - 20;
		//breederbij = 0;
		Debug.Log("dit is lengteerbij" + lengteerbij);
		Debug.Log("dit is nummervancubus" + nummervancubus); 
		Debug.Log("dit is breederbij" + breederbij); 
		GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube.transform.position = new Vector3 (breederbij, hoogteerbij, lengteerbij);
		cube.transform.localScale = new Vector3 (breedte, length, hoogte);














	/* if (breederbij <= 80 + newensizeennew) {
			if (breederbij >= 120 && runonetime <= 1) {
				breederbij = 0;
				nummervancubus = 0;
				Debug.Log("Hoi" + breederbij);
				lengteerbij = 0 - newensizeennew - 20;
				lengteerbijvanfunctie = -20;
				runonetime++;
	}

			//breederbij = 0;
	
			GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cube.transform.position = new Vector3 (breederbij, hoogteerbij, lengteerbij);
			cube.transform.localScale = new Vector3 (breedte, length, hoogte);
			//GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			//cube.transform.position = new Vector3(0, 0, 0);
			//cube.transform.localScale = new Vector3 (2, length, 2);

		}
			else{
			//nummertje = 0;
			Debug.Log("dit is breederbij de voor if statement" + breederbij); 
			if (breederbij >= 120 && runonetime <= 1) {
				breederbij = 0;
				nummervancubus = 0;
				Debug.Log("Hoi" + breederbij);
				runonetime++; 
			}
			lengteerbij = 0 - newensizeennew - 20;
			//breederbij = 0;
			Debug.Log("dit is lengteerbij" + lengteerbij);
			Debug.Log("dit is nummervancubus" + nummervancubus); 
			Debug.Log("dit is breederbij" + breederbij); 
				GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
				cube.transform.position = new Vector3 (breederbij, hoogteerbij, lengteerbij);
				cube.transform.localScale = new Vector3 (breedte, length, hoogte);
			}
*/



		
	}
	public void testert(){



	}
	// Update is called once per frame
	void Update () {
	
	}
}
