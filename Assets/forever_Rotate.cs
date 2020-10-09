using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forever_Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public float angle = 90;

    void FixedUpdate()
	{
		this.transform.Rotate(0,0,angle/50);
	}
}
