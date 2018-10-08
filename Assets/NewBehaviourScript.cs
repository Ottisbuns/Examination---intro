using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public SpriteRenderer rend;

    public float speed;
    public float turning;

    public float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer = timer + Time.deltaTime;
        Debug.Log(timer);
         transform.Translate(speed, 0, 0, Space.Self);
        // Får skeppet at åka framåt konstant
        rend.color = Color.white;
        // Ändrar tillbaka skeppets färg till vit om man slutar svänga
        if (Input.GetAxis("Horizontal") != 0) { transform.Rotate(0, 0, turning * Input.GetAxis("Horizontal") - turning * Input.GetAxis("Horizontal") * 2); }
        // Får skeppet att svänga höger eller vänster
        if (Input.GetAxis("Vertical") <0) { transform.Translate(speed - speed * 1.5f, 0, 0, Space.Self); }
        // Får skeppet at bromsa
        if (Input.GetAxis("Horizontal") > 0) { rend.color = Color.blue; }
        // Får skeppet att bli blått när det svänger höger
        if (Input.GetAxis("Horizontal") < 0) { rend.color = Color.green; }
        // Får skeppet att bli grönt när det svänger vänster
        if (Input.GetAxis("Horizontal")<0) { transform.Rotate(0, 0, turning * Input.GetAxis("Horizontal") / 2); }
        // Får skeppet att svänga långsammare åt vänster än åt höger
    }
}
