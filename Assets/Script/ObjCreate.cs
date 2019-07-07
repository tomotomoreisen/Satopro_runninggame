using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ObjCreate : MonoBehaviour {

public GameObject ballPreFab;
public GameObject ballObj;
public GameObject carPreFab;
public GameObject carObj;
float postZ=0;        
    //public GameObject player;
    // Use this for initialization
    void Start () {
	   	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 player = GameObject.Find("Player").transform.position;
        //Vector3 gameObj = ballObj.transform.position;
        float currentZ = player.z;
        if(currentZ - postZ > 30f)
        {
            createObjs();
            postZ = player.z;
        }
    
    }

    void CreateCube()
    {
        GameObject g = Instantiate(ballPreFab, ballObj.transform);
        Vector3 player = GameObject.Find("Player").transform.position;
        g.transform.position = new Vector3(player.x, player.y + 1.5f, player.z + 80.0f);

    }

    void CreateCar()
    {
        GameObject g = Instantiate(carPreFab, carObj.transform);
        Vector3 player = GameObject.Find("Player").transform.position;
        g.transform.localScale = new Vector3(50, 50, 50);
        if (player.x < 1) //レーンが-4, 0 , 4
        {
            g.transform.position = new Vector3(player.x + 4.0f, 0.5f, player.z + 80.0f);
        }
        else
        {
            g.transform.position = new Vector3(player.x, 0.5f, player.z + 80.0f);
        }
    }
    void createObjs()
    {
        CreateCube();
        Observable.Return(Unit.Default).DelayFrame(Random.Range(10, 150)).Subscribe(_ => CreateCar());


    }
}
