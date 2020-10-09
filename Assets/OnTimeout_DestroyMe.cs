using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTimeout_DestroyMe : MonoBehaviour {

	public float limitSec = 3;

	// Use this for initialization
	void Start () {
		//予約
		Destroy(this.gameObject, limitSec);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
