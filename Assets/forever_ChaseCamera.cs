using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forever_ChaseCamera : MonoBehaviour {

	Vector3 base_pos;

	// Use this for initialization
	void Start () {
		base_pos = Camera.main.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LateUpdate()
    {
		Vector3 pos = this.transform.position; //自分の位置
		pos.z = -10; //カメラなので手前に移動
		pos.y = base_pos.y; //カメラの元の高さを使う
		Camera.main.gameObject.transform.position = pos;
    }
}
