using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class savingwithbinary : MonoBehaviour {

	// Use this for initialization

	public string lengtevariable;
	public InputField InputFieldlengte;
	public string mynewvariable;
	void Start () {
	
	}
	public void save(){
		InputFieldlengte.text = mynewvariable; 

		//InputFieldlengte = GameObject.Find("InputFieldlengte");


		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

		savingdata data = new savingdata();
		//data.length = length;
		//data.InputFieldlengte = lengtevariable;
		data.mynewvariable = mynewvariable; 
		//data.inthoi = inthoi;

		bf.Serialize (file, data);
		file.Close ();
	}


	public void Load()
	{
		if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
		{
			// HIER NOG VERDER NOG NIET GOED OVERGENOMEN
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			savingdata data = (savingdata)bf.Deserialize(file);
			file.Close();

			//length = data.length;

			data.mynewvariable = mynewvariable; 
			//InputFieldlengte = data.InputFieldlengte;

		}
	}
	[Serializable]
	class savingdata{
		public float length;
		//public InputField InputFieldlengte;
		//InputFieldlengte.text = mynewvariable; 
		public string mynewvariable;
		public int inthoi;

	}
	public void show (){
		Debug.Log(mynewvariable);
	}
	// Update is called once per frame
	void Update () {
		Debug.Log(mynewvariable);
	}
}
