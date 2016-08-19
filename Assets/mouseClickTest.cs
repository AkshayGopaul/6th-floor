using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class mouseClickTest : MonoBehaviour {

    public string test;

    public static int ProbValue;
    public InputField monitor;
    public Dropdown ProbAsset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
        ProbValue = ProbAsset.value;
        //test = ProbAsset.itemText;
    // Debug.Log(ProbAsset.captionText.text); --------------------------------
        

    }

    void OnMouseDown() {

        if (gameObject.name== "computerAkshay") {
            //Debug.Log("Clicked on the Akshay Computer");
            monitor.text = "Akshay";
        }

        if (gameObject.name == "computerLokesh")
        {
            //Debug.Log("Clicked on the Lokesh Computer");
            monitor.text = "Lokesh";
        }

    }
}
