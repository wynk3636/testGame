using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveH : MonoBehaviour {

	public float speed = 1;

	// Use this for initialization
	void Start()
	{
	}


	// Update is called once per frame
	void Update()
	{
		//this.transform.Translate(0.1f, 0, 0);
	}

	void FixedUpdate()
	{
		this.transform.Translate(speed / 50, 0, 0);
		//this.transform.Translate(0, speed / 50, 0);
	}
}
