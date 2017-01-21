using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor.UI;
using UnityEngine.UI;

public class Gui : MonoBehaviour {
    public GUISkin style = null;
    public GameObject arcamera;
    public GameObject invoeren;
    public GameObject inventaris;
    public GameObject text;
   
    // Use this for initialization
    void Start () {

        
    }
    private void OnGUI()
    {
        GUI.skin = style;
        GameObject arcamera;
        GameObject invoeren;
        GameObject inventaris;
        GameObject text;
    }
    // Update is called once per frame
 
	void Update () {
		
	}
}
