using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forever_Escape : MonoBehaviour {

	public string targetObjectName;
	public float speed = 1;

	GameObject targetObject;
	Rigidbody2D rbody;

	// Use this for initialization
	void Start()
	{
		//目標オブジェクトを見つける
		targetObject = GameObject.Find(targetObjectName);

		rbody = GetComponent<Rigidbody2D>();
		rbody.gravityScale = 0;
		rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}

	// Update is called once per frame
	void Update()
	{

		//オブジェクトの方向を調べる
		Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;

		//その方向と逆に進む
		float vx = dir.x * -speed;
		float vy = dir.y * -speed;
		rbody.velocity = new Vector2(vx, vy);

		this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
	}
}
