using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float speed;
    public float turning;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         transform.Translate(speed, 0, 0, Space.Self);
        // Får skeppet at åka framåt konstant
        if (Input.GetAxis("Horizontal") != 0) { transform.Rotate(0, 0, turning * Input.GetAxis("Horizontal")); }
        // Får skeppet att svänga höger eller vänster
        if (Input.GetAxis("Vertical") <0) { transform.Translate(speed - speed * 1.5f, 0, 0, Space.Self); }
        // Får skeppet at bromsa
    }
}
