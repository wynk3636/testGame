using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMouseDown_Roulette : MonoBehaviour {

	public float maxSpeed = 50;
	float speed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
		speed = maxSpeed;
    }

    private void FixedUpdate()
    {
		speed = speed * (float)0.97;
		this.transform.Rotate(0, 0, speed);
    }
}
