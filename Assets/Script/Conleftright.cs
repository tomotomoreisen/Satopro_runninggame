using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conleftright : MonoBehaviour {
bool rlx = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
void Update () {
			Vector3 tmp = GameObject.Find("Player").transform.position;
		if(Input.GetKey("x") && rlx == false) {
			rlx = true;
			if(tmp.x + 4 < 6){

				GameObject.Find("Player").transform.position = new Vector3(tmp.x + 4, tmp.y, tmp.z);
			}
			Invoke("DelayMethod", 1.0f);
		}
		if(Input.GetKey("z") && rlx == false) {
			rlx = true;
			if(tmp.x - 4 >-6){
				GameObject.Find("Player").transform.position = new Vector3(tmp.x - 4, tmp.y, tmp.z);
			}
			Invoke("DelayMethod", 1.0f);
		}
}

void DelayMethod(){
	    if(rlx){
				rlx = false;
			};
		}
}
