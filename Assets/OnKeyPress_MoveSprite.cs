using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン切り替えに使用するライブラリ

public class OnKeyPress_MoveSprite : MonoBehaviour {

	public float speed = 2;
	public float jumppower = 8;

	float vx = 0;
	//float vy = 0;
	bool leftFlag = false;
	bool pushFlag = false;
	bool jumpFlg = false;
	bool groundFlag = false;

	Rigidbody2D rbody;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody2D>();
		//rbody.gravityScale = 0;
		rbody.constraints = RigidbodyConstraints2D.FreezeRotation; //衝突時に回転させない
	}
	
	// Update is called once per frame
	void Update () {
		vx = 0;
		//vy = 0;

		if (Input.GetKey("right"))
		{
			vx = speed; //右に進む移動量をいれる
			leftFlag = false;
		}
		if (Input.GetKey("left"))
		{
			vx = -speed; //右に進む移動量をいれる
			leftFlag = true;
		}
		if ((Input.GetKey("up") || Input.GetKey("space")) && groundFlag)
		{
			//vy = speed; //右に進む移動量をいれる
			//leftFlag = false;
            if(pushFlag == false)//押しっぱなしじゃなければ
            {
				jumpFlg = true;
				pushFlag = true;
            }
		}
        else
        {
			pushFlag = false;
        }
        /*
		if (Input.GetKey("down"))
		{
			vy = -speed; //右に進む移動量をいれる
			leftFlag = false;
		}
        */
		if ((Input.GetKeyUp("space")) && (Time.timeScale == 0))
        {
			SceneManager.LoadScene(0); // 最初から
		}
	}


	int count = 0;

    void FixedUpdate()
	{
		//this.transform.Translate(vx/50,vy/50,0);
		rbody.velocity = new Vector2(vx, rbody.velocity.y); //移動する
		this.GetComponent<SpriteRenderer>().flipX = leftFlag; // 左右の向きを変える

        if (jumpFlg)
        {
			jumpFlg = false;
			rbody.AddForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
        }

        /*
        if(count == 0)
		{
			this.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
		}
		if (count == 50)
		{
			this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
		}

		count = count + 1;
        */
        //rbody.velocity = new Vector2(vx, vy);
		//this.GetComponent<SpriteRenderer>().flipX = leftFlag;
	}

    //足が何かに触れたら
    private void OnTriggerStay2D(Collider2D collision)
    {
        groundFlag = true;
    }

    //足が触れてない時
    private void OnTriggerExit2D(Collider2D collision)
    {
		groundFlag = false;
    }
}
