using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sometime_Flip : MonoBehaviour {

	public int maxCount = 50;

	int count = 0;
	bool flipFlag = false;

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
			this.transform.Rotate(0, 0, 180); //180度回転
			count = 0;

			flipFlag = !flipFlag; //上下反転
			this.GetComponent<SpriteRenderer>().flipY = flipFlag;
		}
	}
}
