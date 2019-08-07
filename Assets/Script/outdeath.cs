using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outdeath : MonoBehaviour {
public GameObject neko;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 tmp = GameObject.Find("Player").transform.position;
		if(neko.transform.position.z < tmp.z - 5f){
			Destroy(neko);
			Debug.Log("にゃあああん！！！");
		}
	}
}
