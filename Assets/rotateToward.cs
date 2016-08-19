using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class rotateToward : MonoBehaviour {

    public Text txtDistance; // magnitude
    public int intDistance; // variable to store magnitude in an int

    public int moveSpeed = 10;  //camera
    public int rotationSpeed = 50; //camera


    private Transform currentObject; //arrow
    private Transform target; // Arrow
    private Transform marker; // Arrow
    private float speed=1; // Arrow
    int problemV; // Arrow

    // Use this for initialization
    void Start () {

        marker = GameObject.Find("ppiramid").transform;
        target = GameObject.Find("arrow").transform;
        currentObject = GameObject.Find("arrow").transform;
      


    }
	
	// Update is called once per frame
	void Update () {

        problemV = mouseClickTest.ProbValue; //assigning variable from another script to problem v variable       

        cameraMovement();
        targetedComputer();
        arrowTarget();
        distance();

        if (target.name!= "arrow") {
            MoveMarker();
        }

    }

    void MoveMarker()
    {
        marker = GameObject.Find("ppiramid").transform;
        marker.transform.position = new Vector3(target.parent.parent.parent.parent.parent.position.x, target.parent.parent.parent.parent.parent.position.y+4, target.parent.parent.parent.parent.parent.position.z);
        //Debug.Log(target.parent.parent.parent.parent.parent.position.x);  
    }

    void arrowTarget() {

        Vector3 targetDir = target.position - currentObject.transform.position;
        float step = speed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(currentObject.transform.forward, targetDir, step, 0.0F);
        Debug.DrawRay(currentObject.transform.position, newDir, Color.red);
        currentObject.transform.rotation = Quaternion.LookRotation(newDir);
    }

    void targetedComputer() {

        if (problemV == 1)
        {
            target = GameObject.Find("computerAkshay").transform;
        }
        else if (problemV == 2)
        {
            target = GameObject.Find("computerLokesh").transform;
        }
        else if (problemV == 3)
        {
            target = GameObject.Find("computerYudish").transform;
        }

    }

    void cameraMovement()
    {


        /* if (Input.GetKeyDown("space")) {
            print("space key was pressed");
            transform.Translate(0, 0, Time.deltaTime);
         */

        //bool up = Input.GetKeyUp(KeyCode.Space); // on key release
        // bool down = Input.GetKeyDown(KeyCode.Space); // check if key has been press


        bool upArrow = Input.GetKey(KeyCode.UpArrow); // key being press continuesly
        bool leftArrow = Input.GetKey(KeyCode.LeftArrow); // key being press continuesly
        bool rightArrow = Input.GetKey(KeyCode.RightArrow); // key being press continuesly
        bool downArrow = Input.GetKey(KeyCode.DownArrow); // key being press continuesly

        bool w = Input.GetKey(KeyCode.W); // key being press continuesly
        bool a = Input.GetKey(KeyCode.A); // key being press continuesly
        bool s = Input.GetKey(KeyCode.S); // key being press continuesly
        bool d = Input.GetKey(KeyCode.D); // key being press continuesly



        if (upArrow == true)
        {
            transform.Translate(0, 0, (Time.deltaTime) * moveSpeed);
        }

        if (downArrow == true)
        {
            transform.Translate(0, 0, ((Time.deltaTime) * moveSpeed) * -1);
        }

        if (leftArrow == true)
        {
            transform.Translate(((Time.deltaTime) * moveSpeed) * -1, 0, 0);
        }

        if (rightArrow == true)
        {
            transform.Translate((Time.deltaTime) * moveSpeed, 0, 0);
        }

        if (w == true)
        {
            transform.Translate(0, (Time.deltaTime) * moveSpeed, 0);
        }

        if (s == true)
        {
            transform.Translate(0, ((Time.deltaTime) * moveSpeed) * -1, 0);
        }

        if (a == true)
        {
            transform.Rotate((Vector3.up * Time.deltaTime * rotationSpeed) * -1, Space.World);
        }

        if (d == true)
        {
            transform.Rotate((Vector3.up * Time.deltaTime * rotationSpeed), Space.World);
        }


    }

    void distance() {

        Vector3 targetMag = target.position - currentObject.transform.position; // Targeted object minus camera object
        txtDistance.text = intDistance.ToString() + " m";
        intDistance= (int)(targetMag.magnitude)/3;
        //Debug.Log(intDistance);
        // float step = speed * Time.deltaTime;
        // Vector3 newDir = Vector3.RotateTowards(currentObject.transform.forward, targetDir, step, 0.0F);
        // Debug.DrawRay(currentObject.transform.position, newDir, Color.red);
        // currentObject.transform.rotation = Quaternion.LookRotation(newDir);

    }



}
