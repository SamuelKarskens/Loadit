using UnityEngine;
using System.Collections;

public class cubus : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public string lengteobject;
	public string breedteobject;
	public string hoogteobject;
	public float newLength;
	public float newBreedte;
	public float breedte;
	public float newHoogte;
	public float hoogte;
	public float length;
	public void cubusgeneren(){
		lengteobject = PlayerPrefs.GetString("saveNom");
		breedteobject = PlayerPrefs.GetString ("saveBreedte");
		hoogteobject = PlayerPrefs.GetString ("saveHoogte");
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
		GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube.transform.position = new Vector3 (0, 0, 0);
		cube.transform.localScale = new Vector3 (breedte, length, hoogte);

	}

	// Update is called once per frame
	void Update () {
	
	}
}
