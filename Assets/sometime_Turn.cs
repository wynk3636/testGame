using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sometime_Turn : MonoBehaviour {

	public float angle = 90;
	public int maxCount = 100;

	int count = 0;

	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
	{
		count = count + 1;

        if(count == maxCount)
		{
			this.transform.Rotate(0, 0, angle);
			count = 0;
		}
	}
}
