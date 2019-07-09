using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRoad : MonoBehaviour {

	private float border = 80;
	public GameObject road1;
	public GameObject road2;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 tmp = GameObject.Find("Player").transform.position;
		if(tmp.z > border){
			CreateMap ();
		}
	}
	void CreateMap(){
		if (road1.transform.position.z < border) {
			border+=80;
			Vector3 temp = new Vector3 (0,0,border);
			road1.transform.position = temp;

		}
		else if (road2.transform.position.z < border) {
			border+=80;
			Vector3 temp = new Vector3 (0,0,border);
			road2.transform.position = temp;
            GameObject.Find("Player").GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>().SpeedUp();

		}
	}


}
