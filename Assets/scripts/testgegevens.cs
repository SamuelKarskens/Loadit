using UnityEngine;
using System.Collections;
using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class testgegevens : MonoBehaviour {
	public float length;
	public float InputFieldlengte;
	public int inthoi;
	// Use this for initialization
	void Start () {
		//float lengthen;
		//float length =  lengthen;
		//Debug.Log ("hello");  
		//Debug.Log (lenght); 
	}


	[System.Serializable]
	class PlayerData{
		public float length;
		public float InputFieldlengte;
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

			data.length = length;
			data.InputFieldlengte = InputFieldlengte;
			data.inthoi = inthoi;
		}
	}


		void update (){
		//int x = 5;
		//Debug.Log(x);  
		Debug.Log(length);
		
		}

}