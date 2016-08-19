using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class touchScriptLeft : MonoBehaviour {

    public float rotateSpeed = 50.0f;
    public float moveSpeed = 10.0f;  //camera
    private float pitch = 0.0f, yaw = 0.0f;

    int invert = -1;

   // private Image Left;
   // private Image Right;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Left = gameObject.GetComponent<Image>();




        if (Input.touchCount > 0)
        {
            pitch -= Input.GetTouch(0).deltaPosition.y * moveSpeed * invert *Time.deltaTime;
            gameObject.transform.Translate(0, pitch ,0);

            yaw += Input.GetTouch(0).deltaPosition.x*rotateSpeed*invert*Time.deltaTime;
            gameObject.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        }

        /*
                if (Input.GetMouseButtonDown(0))
                    Debug.Log("Pressed left click.");

                if (Input.GetMouseButtonDown(1))
                    Debug.Log("Pressed right click.");

                if (Input.GetMouseButtonDown(2))
                    Debug.Log("Pressed middle click.");
                    */

    }


}
