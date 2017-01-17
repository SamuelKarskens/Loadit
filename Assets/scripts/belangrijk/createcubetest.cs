using UnityEngine;
using System.Collections;

public class createcubetest : MonoBehaviour {

	private int cubusnummermineen;

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
	public int numberloadspecificcube = 0;
	public string sizeobject;
	public static float positionpluswidth;
	public float newbreederbij;
	public float afstandbreed = 0;
	public float newsizeobject;
	public float newensize;
	public string storewidthlastcube;
	public float newsizenewobject;
	public float widthlastcube;
	public float halfwidthlastcube;
	public float getalletje = 2;
	public float volgendegetalletje;
	public float newvolggetalletje;
	public string volggetalletje;
	public float widthcubesinside;
	public float voorgetal = 0;
	public string storebreedtecubus1;
	public float newhalfvancubus;
	public float halfvancubus;
	public int testvariable = 0;
	public static float hoogteerbij = 0;
	public static float lengteerbij = 0;
	public int numbercubespecificrow = 0;
	public float lengteerbijvanfunctie = 0;
	public int runonetime = 0;
	public int numberoffirstinrow = 1;
	bool creating = false;
	bool created = false;
	public GameObject cube;
	void Start () {
		

	}

	public void afstandhouden (){
		Debug.Log("afstandhouden aangeroepen!!!!!");
		getalletje = 2;
		nummervoor = PlayerPrefs.GetInt ("nummer");
		//nummervancubus was vroeger nummertje
		//cubusnummermineen = 0;
		cubusnummermineen = numbercubespecificrow - 1;
		Debug.Log ("dit is het nummertje" + numberloadspecificcube); 
		Debug.Log ("dit is het trans" + cubusnummermineen); 

		//stap 1 neemnt de breedte van de eerste cubus
		Debug.Log("Dit is nummer van eerste cube" + numberoffirstinrow);

		


		// als er maar 1 cubus is dan is de afstand om bij de afstand op te tellen 0
		if (cubusnummermineen <= 0) {

			storebreedtecubus1 = PlayerPrefs.GetString ("Breedte_" + numberloadspecificcube);
			if (float.TryParse (storebreedtecubus1, out newhalfvancubus)) {
				halfvancubus = newhalfvancubus;
			}

<<<<<<< HEAD
				positionpluswidth = halfvancubus / 2;
				Debug.Log ("Dit is als if statement is gegaan " + positionpluswidth); 
				hoogteerbij = halfvancubus / 2;
=======
			positionpluswidth = halfvancubus / 2;
			Debug.Log ("Dit is als if statement is gegaan " + positionpluswidth); 
			hoogteerbij = halfvancubus / 2;
>>>>>>> origin/master
			//lengteerbij = 0 - newhalfnewvancubus / 2 - lengteerbijvanfunctie;
		}

		// anders roep je van alle cubussen tussen het eerste en laatste cubusje de breedte op.
		// en voeg je die toe aan de totale breedte
		else {
			
			Debug.Log (cubusnummermineen);  
		
			while (getalletje >= 2 && getalletje <= cubusnummermineen) {
				Debug.Log ("Start van while loop"); 
				volggetalletje = PlayerPrefs.GetString ("Breedte_" + getalletje);
				if (float.TryParse (volggetalletje, out newvolggetalletje)) {
					volgendegetalletje = newvolggetalletje;
				}
				widthcubesinside = widthcubesinside + volgendegetalletje;
				getalletje++; 

				}
			 

			Debug.Log("Dit is het getalletje van de while loop aan het einden" + getalletje);  

	

			//stap 1 neemnt de breedte van de eerste cubus
			storebreedtecubus1 = PlayerPrefs.GetString ("Breedte_" + numberoffirstinrow);
			if (float.TryParse (storebreedtecubus1, out newhalfvancubus)) {
				halfvancubus = newhalfvancubus;
			}

			// stap 2 neem de breedte van de laatste cubus

			storewidthlastcube = PlayerPrefs.GetString ("Breedte_" + numberloadspecificcube);  
			if (float.TryParse (storewidthlastcube, out newsizenewobject)) {
				widthlastcube = newsizenewobject;

			}
			newhalfvancubus = halfvancubus / 2; 
			halfwidthlastcube = widthlastcube / 2; 
			Debug.Log (newhalfvancubus);
			Debug.Log (halfwidthlastcube);
			Debug.Log (widthcubesinside);
			positionpluswidth = newhalfvancubus + newhalfvancubus + halfwidthlastcube + widthcubesinside;
			//reset de widthcubesinside zodat de breedte van de vorige er niet bij komt
			widthcubesinside = 0;

			hoogteerbij = halfwidthlastcube;
			//deze lengte moet er nog bij later
			//lengteerbij = 0 - newensizeennew - lengteerbijvanfunctie;
		}

		createcubussen();
	}



	public void loaddata(){
		numbercubespecificrow++;
		numberloadspecificcube++;
		if (positionpluswidth >= 80 && runonetime <= 1) {
			positionpluswidth = 0;
			numbercubespecificrow = 1;
			Debug.Log("Hoi" + positionpluswidth);
			lengteerbij = 0 - halfwidthlastcube - 20 -30;
			


			/*storebreedtecubus1 = PlayerPrefs.GetString ("Breedte_" + numberoffirstinrow);
			if (float.TryParse (storebreedtecubus1, out newhalfvancubus)) {
				halfvancubus = newhalfvancubus;
			}

			positionpluswidth = halfvancubus / 2;
			hoogteerbij = halfvancubus / 2;
*/








			//numberoffirstinrow = numberloadspecificcube; 
			//Debug.Log ("uiteindelijk nummer" + numberoffirstinrow);  
			//runonetime++;
			
			
		}














		//waar nummer vancubus staat hieronder was vroeger nummertje
		lengteobject = PlayerPrefs.GetString("lengte_" + numberloadspecificcube );
		breedteobject = PlayerPrefs.GetString ("Breedte_" + numberloadspecificcube );
		hoogteobject = PlayerPrefs.GetString ("Hoogte_" + numberloadspecificcube );
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
		afstandhouden();
	}

	public void createcubussen(){
		//nummertje = PlayerPrefs.GetInt ("nummertje");  
		//nummertje++;
		//Debug.Log (nummertje); 
		//PlayerPrefs.SetInt("nummertje", nummertje);




		//lengteerbij = 0 - newensizeennew - 20;
		//breederbij = 0;
		Debug.Log("dit is lengteerbij" + lengteerbij);
		Debug.Log("dit is nummervancubus" + numbercubespecificrow); 
		Debug.Log("dit is breederbij" + positionpluswidth); 
		//cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
		creating = true;
		//cube.transform.position = new Vector3 (positionpluswidth, hoogteerbij, lengteerbij);
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
		void Update () {
			//cube.transform.position = Vector3.Lerp(new Vector3(positionpluswidth, hoogteerbij,50), new Vector3(positionpluswidth, hoogteerbij, lengteerbij), 0.1f);
			if(creating){
				
				GameObject cubeClone = Instantiate(cube, new Vector3(positionpluswidth, hoogteerbij,50), Quaternion.Euler(new Vector3(0,0,0)));
				cubeClone.transform.localScale = new Vector3 (breedte, length, hoogte);

				creating = false;
			}

			
	}
	public void testert(){



	}
	// Update is called once per frame

}
