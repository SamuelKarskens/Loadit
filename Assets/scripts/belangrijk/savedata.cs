using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

 public class savedata : MonoBehaviour {
	//[System.Serializable]
	public float length;
	public float newLength;
	//InputField InputFieldlengte;
	public int inthoi;
	float inputtie;
	//[System.Serializable]
	void handig(){
		storelengte storeScript = GetComponent<storelengte>();
		if (float.TryParse(storeScript.InputFieldlengte.text, out newLength))
		{
			length = newLength;

		}

	}
	float supercool;
	[System.Serializable]
	class super{
		
		public float length;
		//[SerializeField]
		//length = newLength;
		//= GameObject.Find("InputFieldlengte");
		//int Hoi = 5;
		//public static float unput;
	}
	// Use this for initialization
	public void save(){
		

		//InputFieldlengte = GameObject.Find("InputFieldlengte");


		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

		savingdata data = new savingdata();
		data.length = length;
		//data.InputFieldlengte = super.unput; 
		data.inthoi = inthoi;

		bf.Serialize (file, data);
		file.Close ();
	}


	[System.Serializable]
	class savingdata{
		public float length;
		public InputField InputFieldlengte;
		public int inthoi;

	}


}
