using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMouseDown_Rotate : MonoBehaviour {

	public float angle = 360;

	float rotateAngle = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //タッチしたら
    private void OnMouseDown()
    {
		rotateAngle = angle;

	}

    //タッチをやめたら
    private void OnMouseUp()
    {
		rotateAngle = 0;
    }

    private void FixedUpdate()
    {
		this.transform.Rotate(0, 0, rotateAngle / 50);
    }
}
