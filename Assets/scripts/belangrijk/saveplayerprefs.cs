using UnityEngine;
using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class saveplayerprefs : MonoBehaviour {
	public float length;
	public float newLength;
	public InputField InputFieldlengte;
	public InputField InputFieldbreedte;
	public InputField InputFieldhoogte;
	public InputField InputFieldname; 
	public int nummer = 0;
	// Use this for initialization
	void Start () {
		
	}

	void handig(){
		storelengte storeScript = GetComponent<storelengte>();
		if (float.TryParse(storeScript.InputFieldlengte.text, out newLength))
		{
			length = newLength;

		}

	}
	public void saving(){
		nummer = PlayerPrefs.GetInt("nummer");
		PlayerPrefs.SetString("lengte_" + nummer, InputFieldlengte.text);
		Debug.Log (nummer); 
		PlayerPrefs.SetString("Breedte_" + nummer, InputFieldbreedte.text); 
		PlayerPrefs.SetString("Hoogte_" + nummer, InputFieldhoogte.text);   
	}
	// Update is called once per frame
	void Update () {
		
	}
}
