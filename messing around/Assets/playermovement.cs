using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {

    public Rigidbody pb;
    public float forwardForce = 3000f;
   
	// Update is called once per frame
	void FixedUpdate ()
    {

        pb.AddForce(forwardForce * Time.deltaTime, 0,0);


      
        
    }
}
