using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventaris : MonoBehaviour {

    public Text name;
    public GameObject text;
    public string hello;
    int numberloadspecificcube = 1;
    string lengteobject;
    float length = 1;
    float newLength;
    public GameObject Gridwithourelements;
    GameObject insidebutton;
    public GameObject buttondieeralwas;
    //public Transform contentPanel;
    //public ShopScrollList otherShop;
   // public Text myGoldDisplay;
    //public SimpleObjectPool ;
    // Use this for initialization
    void Start () {

        

        //transform.parent = Ourawesomelist.Gridwithourelements.transform;
    }
    public void changetext()
    {
        
        while (length > 0 && length < 30)
        {
            Debug.Log("while loop begonnen");
            lengteobject = PlayerPrefs.GetString("lengte_" + numberloadspecificcube);
            if (float.TryParse(lengteobject, out newLength))
            {
                length = newLength;

            }
            numberloadspecificcube++;


            Instantiate(buttondieeralwas, transform.parent = Gridwithourelements.transform);
            //button.transform.parent = Gridwithourelements.transform;








            /*     GameObject button = new GameObject();
                 // button.transform.parent = panel;
                 button.AddComponent<RectTransform>();
                 button.AddComponent<Button>();
                 button.AddComponent<Image>();
                 button.AddComponent<LayoutElement>();
                 button.GetComponent<LayoutElement>().flexibleWidth = 1;
                 button.GetComponent<LayoutElement>().preferredHeight = 87;
                 button.GetComponent<RectTransform>();



                 //button.transform.position = position;

                 // button.GetComponent<Button>().onClick.AddListener(method);
                 //button.GetComponentInChildren(Text).text = "testing";
                 // Gridwithourelements = GameObject.Find("Gridwithourelements");
                 button.transform.parent = Gridwithourelements.transform;

                 //  GameObject newButton = buttonObjectPool.GetObject();











                 // GameObject textinbutton = new GameObject();
                 // textinbutton.AddComponent<Text>();
                 // transform.parent = insidebutton.transform;  */


        }



    }
    public void createtext()
    {

        GameObject textinbutton = new GameObject();
         textinbutton.AddComponent<Text>();
        insidebutton = GameObject.Find("New Game Object");
        textinbutton.transform.parent = insidebutton.transform;
        



    }
    // Update is called once per frame

    void Update () {
		
	}
}
