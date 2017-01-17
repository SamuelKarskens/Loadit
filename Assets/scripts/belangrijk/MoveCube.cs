using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {
	bool movable = true;
	bool inPlace = false;
	Vector3 lockedPos;
	public Material blue;
	public Material red;
	public Material green;
	public Material yellow;
	int randomNum;
	GameObject imageTarget;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3(createcubetest.positionpluswidth,transform.localScale.y / 2,createcubetest.lengteerbij - 100);
		randomNum = Random.Range(1,4);
		if(randomNum == 1){
			GetComponent<Renderer>().material = blue;
		}
		if(randomNum == 2){
			GetComponent<Renderer>().material = red;
		}
		if(randomNum == 3){
			GetComponent<Renderer>().material = yellow;
		}
		if(randomNum == 4){
			GetComponent<Renderer>().material = green;
		}
		imageTarget = GameObject.Find("ImageTarget");
		transform.parent = imageTarget.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(movable){
			transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z + 2);
		}
		
	}
	void OnTriggerEnter(Collider collider){
		if(collider.name == "Stopper" || collider.name == "Cube(Clone)"){
			Debug.Log("Colliding!");
			movable = false;
		}
		
	}
	void OnTriggerExit(Collider collider){
		if(collider.name == "Stopper" || collider.name == "Cube(Clone)"){
			inPlace = true;


		}
	}
	void OnTriggerStay(Collider collider){
		if(collider.name == "Stopper" || collider.name == "Cube(Clone)"){
			if(inPlace == false){
				transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z - 0.1f);
			}
		}
	}
}
