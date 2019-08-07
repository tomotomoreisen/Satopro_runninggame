using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class objCreate : MonoBehaviour
{

    public GameObject ballPreFab;
    public GameObject ballObj;
    public GameObject carPreFab;
    public GameObject carObj;
    public GameObject boardPreFab;
    public GameObject boardObj;
    float postZ = 0;
    //public GameObject player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 gameObj = ballObj.transform.position;
        GameObject player = GameObject.Find("Player");
        Vector3 playerp = player.transform.position;
        float currentZ = playerp.z;
        if (currentZ - postZ > 30f)
        {
            createObjs();
            postZ = playerp.z;
        }

    }

    void CreateCube()
    {
        GameObject player = GameObject.Find("Player");
        GameObject g = Instantiate(ballPreFab, ballObj.transform);
        Vector3 playerpos = player.transform.position;
        g.transform.position = new Vector3(playerpos.x, playerpos.y + 1.5f, playerpos.z + 80.0f);
        Vector3 createdObj = g.transform.position;
    }

    void CreateBoard()
    {
        GameObject player = GameObject.Find("Player");
        GameObject g = Instantiate(boardPreFab, boardObj.transform);
        g.transform.localScale = new Vector3(50, 50, 50);
        g.transform.Rotate(0, 0, 85);
        Vector3 playerpos = player.transform.position;
        if (playerpos.x > -1) //レーンが-4, 0 , 4
        {
            g.transform.position = new Vector3(playerpos.x - 4.0f, 0f, playerpos.z + 80.0f);
        }
        else
        {
            g.transform.position = new Vector3(playerpos.x, 0.5f, playerpos.z + 80.0f);
        }
        Vector3 createdObj = g.transform.position;
    }

    void CreateCar()
    {
        GameObject player = GameObject.Find("Player");
        GameObject g = Instantiate(carPreFab, carObj.transform);
        g.transform.localScale = new Vector3(50, 50, 50);
        Vector3 playerpos = player.transform.position;
        if (playerpos.x < 1) //レーンが-4, 0 , 4
        {
            g.transform.position = new Vector3(playerpos.x + 4.0f, 0.5f, playerpos.z + 80.0f);
        }
        else
        {
            g.transform.position = new Vector3(playerpos.x, 0.5f, playerpos.z + 80.0f);
        }
    }
    void createObjs()
    {
        CreateCube();
        Observable.Return(Unit.Default).DelayFrame(Random.Range(10, 150)).Subscribe(_ => CreateCar());
        CreateBoard();


    }
}
