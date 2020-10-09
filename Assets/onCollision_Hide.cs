using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision_Hide : MonoBehaviour {

	public string targetObjectName;
	public string hideObjectName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    [SerializeField]
    GameObject hideObject;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //衝突したものがターゲットなら
        if(collision.gameObject.name == targetObjectName)
        {
            //消すオブジェクトを探して(この場合は非アクティブなオブジェクトは取得できないのでNG)
			//GameObject hideObject = GameObject.Find(hideObjectName);

            Debug.Log("hide or show");

            if (hideObject.activeSelf)
            {
                //消す
                hideObject.SetActive(false);
            }
            else
            {
                //つける
                hideObject.SetActive(true);
            }
        }
    }
}
