using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision_StopGame : MonoBehaviour {

	public string targetObjectName;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == targetObjectName)
        {
			Time.timeScale = 0;
        }
    }
}
