using UnityEngine;
using System.Collections;

public class resetplusplus : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public int nummer = 0;
	public void reset (){
		nummer = PlayerPrefs.GetInt("nummer");
		//nummer = 1;
		PlayerPrefs.SetInt("nummer", 0);

	}
	void Update () {
	
	}
}
