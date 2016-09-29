using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class UIbtnScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Transform btnfront;
    private Transform btnBack;
    private Transform btnRight;
    private Transform btnLeft;
 
    private Transform btnUp;
    private Transform btnDown;
    private Transform btnRotateLeft;
    private Transform btnRotateRight;

    private Transform Cam;

    private bool checkbtnfront=false;
    private bool checkbtnback = false;
    private bool checkbtnright = false;
    private bool checkbtnleft = false;

    private bool checkbtnUp = false;
    private bool checkbtnDown = false;
    private bool checkbtnRotateLeft = false;
    private bool checkbtnRotateRight = false;
    
    

     int moveSpeed = 10;  //camera
    int rotationSpeed = 50; //camera
    // Use this for initialization
    void Start () {
	    btnfront = GameObject.Find("Front").transform;
        btnBack = GameObject.Find("Back").transform;
        btnRight = GameObject.Find("Right").transform;
        btnLeft = GameObject.Find("Left").transform;

        btnUp = GameObject.Find("Up").transform;
        btnDown = GameObject.Find("Down").transform;
        btnRotateRight = GameObject.Find("RotateRight").transform;
        btnRotateLeft = GameObject.Find("RotateLeft").transform;

        Cam = GameObject.Find("Main Camera").transform;   
       
    }

    public void OnPointerDown(PointerEventData eventData) {
        if (gameObject.name == "Front") {
            checkbtnfront = true;
            Debug.Log("Front ON");
        }
        else if (gameObject.name == "Back") {
            checkbtnback = true;
            Debug.Log("Back ON");
        }
        else if (gameObject.name == "Right") {
            checkbtnright = true;
            Debug.Log("Right ON");
        }
        else if (gameObject.name == "Left") {
            checkbtnleft = true;
            Debug.Log("Left ON");
        }
        else if (gameObject.name == "Up") {
            checkbtnUp = true;
            Debug.Log("Up ON");
        }
        else if (gameObject.name == "Down")
        {
            checkbtnDown = true;
            Debug.Log("Down On");
        }
        else if (gameObject.name == "RotateLeft") {
            checkbtnRotateLeft = true;
            Debug.Log("Rotate Left On");
        }
        else if (gameObject.name== "RotateRight")
        {
            checkbtnRotateRight = true;
            Debug.Log("RotateRight On");
        }
       
    }

    public void OnPointerUp(PointerEventData eventData) {
        if (gameObject.name == "Front")
        {
            checkbtnfront = false;
            Debug.Log("Front OFF");
        }
        else if (gameObject.name == "Back")
        {
            checkbtnback = false;
            Debug.Log("Back OFF");
        }
        else if (gameObject.name == "Right")
        {
            checkbtnright = false;
            Debug.Log("Right OFF");
        }
        else if (gameObject.name == "Left")
        {
            checkbtnleft = false;
            Debug.Log("Left OFF");
        }
        else if (gameObject.name == "Up")
        {
            checkbtnUp = false;
            Debug.Log("Up off");
        }
        else if (gameObject.name == "Down") {
            checkbtnDown = false;
            Debug.Log("Down off");
        }
        else if (gameObject.name == "RotateLeft") 
        {
            checkbtnRotateLeft = false;
            Debug.Log("RotateLeft Off");
        }
        else if (gameObject.name == "RotateRight")
        {
            checkbtnRotateRight = false;
            Debug.Log("RotateRight Off");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        movingCamera();
    }

    void movingCamera()
    {
        if (checkbtnfront == true)
        {
            Cam.transform.Translate(0, 0, (Time.deltaTime) * moveSpeed);
        }

        if (checkbtnback == true)
        {
            Cam.transform.Translate(0, 0, ((Time.deltaTime) * moveSpeed) * -1);
        }

        if (checkbtnleft == true)
        {
            Cam.transform.Translate(((Time.deltaTime) * moveSpeed) * -1, 0, 0);
        }

        if (checkbtnright == true)
        {
            Cam.transform.Translate((Time.deltaTime) * moveSpeed, 0, 0);
        }

        if (checkbtnUp== true) {
            Cam.transform.Translate(0, (Time.deltaTime) * moveSpeed, 0);
        }

        if (checkbtnDown==true) {
            Cam.transform.Translate(0, ((Time.deltaTime) * moveSpeed) * -1, 0);
        }

        if (checkbtnRotateLeft==true) {
            Cam.transform.Rotate((Vector3.up * Time.deltaTime * rotationSpeed) * -1, Space.World);
        }

        if (checkbtnRotateRight==true) {
            Cam.transform.Rotate((Vector3.up * Time.deltaTime * rotationSpeed), Space.World);
        }
       


    }
}
