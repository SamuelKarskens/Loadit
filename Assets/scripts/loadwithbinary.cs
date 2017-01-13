using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class loadwithbinary : MonoBehaviour {

	// Use this for initialization
	public string mynewvariable;
	void Start () {
	
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
		
	}
}
