using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class touchScreenScript : MonoBehaviour {
    public Texture2D button1;
    public Texture2D button2;
    // Use this for initialization
    void Start () {
        GetComponent<GUITexture>().texture = button1;
    }
	
	// Update is called once per frame
	void Update () {

        foreach (Touch touch in Input.touches)
        {

            if (GetComponent<GUITexture>().HitTest(touch.position) && touch.phase != TouchPhase.Ended)
            {
                GetComponent<GUITexture>().texture = button2;
                transform.Translate(Vector3.right * 30 * Time.smoothDeltaTime);

            }
            else if (GetComponent<GUITexture>().HitTest(touch.position) && touch.phase == TouchPhase.Ended)
            {

                GetComponent<GUITexture>().texture = button1;

            }

        }
    }
}
