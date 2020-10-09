using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forever_MoveH : MonoBehaviour {

	public float speed = 1;
	Rigidbody2D rbody;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody2D>();
		rbody.gravityScale = 0;
		rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}


	// Update is called once per frame
	void Update () {
		//this.transform.Translate(0.1f, 0, 0);
		rbody.velocity = new Vector2(speed, 0);
	}

    //何かと衝突したことを調べる
    private void OnCollisionEnter2D(Collision2D collision)
    {
		speed = -speed;
		this.GetComponent<SpriteRenderer>().flipX = (speed < 0);
    }

    void FixedUpdate()
	{
		this.transform.Translate(speed/50,0,0);
		//this.transform.Translate(0, speed / 50, 0);
	}
}
