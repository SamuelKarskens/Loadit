using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class storebreedte : MonoBehaviour {


	void LockInput(InputField input)
	{
		if (input.text.Length > 0) {
			Debug.Log ("hallljh");
		} else if (input.text.Length == 0) {
			Debug.Log ("not");
		}
	}
	void Start () {
		//GameObject inputFieldGo = GameObject.Find("InputField breedte");
		//InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();
		//Debug.Log(inputFieldCo.text);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}


