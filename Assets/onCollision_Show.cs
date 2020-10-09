using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision_Show : MonoBehaviour
{

	public string targetObjectName;
	public string showObjectName;
	GameObject showObject;

	// Use this for initialization
	void Start()
	{
		showObject = GameObject.Find(showObjectName);
		showObject.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("touch");
		//衝突したものがターゲットなら
		if (collision.gameObject.name == targetObjectName)
		{
			showObject.SetActive(true);
		}
	}
}
