using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class createcube : MonoBehaviour {
	//public GameObject coolobject; 
	// Use this for initialization

	public float length;
	public float newLength;
	public InputField InputFieldlengte;
	public int inthoi;
	void Start () {

		//GameObject InputFieldLengte = GameObject.Find ("InputFieldlengte");
		//storelengte storeScript = GetComponent<storelengte>();
		//float.Parse(storeScript.InputFieldlengte);

		//int inputvet;
		//inputvet = Convert.ToInt32(storeScript.InputFieldlengte.text);
		//var ex = 10;
		//int z = 10;

		//float inputvet = float storeScript.inputfieldlengte;

		//float inputvet = float.Parse(storeScript.InputFieldlengte.text);






		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.transform.position = new Vector3(0, 0, 0);
		cube.transform.localScale = new Vector3 (2, 2, 2);
	}
	//public class inputvetten {
		//float inputvet;
	
	//}
	//storeScript.InputFieldlengte
	// Update is called once per frame
	//public float inputvet = float.Parse(storeScript.InputFieldlengte.text);
//	storelengte storeScript = GetComponent<storelengte>();
	//private var wat string = "800"; 
	//void OnToi(){



	//}
	//public float Length;
	//void OnGUI (){
		//float newLength;

		//string storeScript.InputFieldlengte.text = string storenlengten;

		//string storeScript.InputFieldlengte.text = GUILayout.TextField(Length.ToString("0.00"));

		//storelengte storeScript = GetComponent<storelengte>();
		//if (float.TryParse(storeScript.InputFieldlengte.text, out newLength))
		//{
		//	Length = newLength;
		//}
	
	GameObject rotator;

	void Update () {




		//if (float.TryParse(storeScript.InputFieldlengte.text, out newLength))
		//{
		//	Length = newLength;
		//}
		//float inputgekken = float.Parse(inputvetten);
		//storelengte storeScript = GetComponent<storelengte>();
		//storelengte storeScript = GetComponent<storelengte>();
		//if (float.TryParse(storeScript.InputFieldlengte.text, out newLength))
		//{
			//length = newLength;

		//}
		rotator = GameObject.Find("Cube");

			rotator.gameObject.transform.localScale = new Vector3 (2, 2, 2); 
	}
	// HEEL BELANGERIJK VOOR SAVING DATA





	public void save(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

		PlayerData data = new PlayerData ();
		data.length = length;
		data.InputFieldlengte = InputFieldlengte; 
		data.inthoi = inthoi;

		bf.Serialize (file, data);
		file.Close ();
	}


	[System.Serializable]
	class PlayerData{
		public float length;
		public InputField InputFieldlengte;
		public int inthoi;

	}

   public void Load()
	{
		if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
		{
				// HIER NOG VERDER NOG NIET GOED OVERGENOMEN
				BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			    PlayerData data = (PlayerData)bf.Deserialize(file);
			    file.Close();

				length = data.length;
			InputFieldlengte = data.InputFieldlengte;

			}
			}
}