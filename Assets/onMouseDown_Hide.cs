using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMouseDown_Hide : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //タッチしたら
    private void OnMouseDown()
    {
		this.gameObject.SetActive(false);
    }
}
