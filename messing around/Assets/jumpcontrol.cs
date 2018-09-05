using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpcontrol : MonoBehaviour {

    public KeyCode jumpKey;
    public string midjump = "n";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if ((Input.GetKeyDown (jumpKey)) && (midjump=="n"))

        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 0);
            midjump = "y";
        }

        if (GetComponent<Rigidbody> ().velocity.y==0)
            midjump = "n";
    }
}
