using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sometime_RandomCreatePrefab : MonoBehaviour {

	public GameObject newPrefab;
	public float intervalSec = 1;

	// Use this for initialization
	void Start () {
		//指定秒ごとにCreatePrefabを行う予約
		InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
	}

    void CreatePrefab()
    {
		Vector3 area = GetComponent<SpriteRenderer>().bounds.size; //オブジェクトの範囲内にランダムに

		Vector3 newPos = this.transform.position;
		newPos.x += Random.Range(-area.x / 2, area.x / 2);
		newPos.y += Random.Range(-area.y / 2, area.y / 2);
		newPos.z = -5;

		GameObject newGameObject = Instantiate(newPrefab) as GameObject;
		newGameObject.transform.position = newPos;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
