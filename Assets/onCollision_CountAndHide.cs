using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision_CountAndHide : MonoBehaviour {

	public string targetobjectName;
	public int addValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == targetobjectName)
        {
			GameCounter.value = GameCounter.value + addValue;

			this.gameObject.SetActive(false);
        }
    }
}
