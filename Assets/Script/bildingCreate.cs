using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bildingCreate : MonoBehaviour {

    public GameObject buildingObj;
    public GameObject buildingPref;
    float postZ = 0f; 

    // Use this for initialization
    void Start () {


    }

    // Update is called once per frame
    void Update () {
        GameObject player = GameObject.Find("Player");
        Vector3 playerp = player.transform.position;
        float currentZ = playerp.z;
        if (currentZ - postZ > 10f)
        {
            CreateBuilding();
            postZ = playerp.z;
        }

    }

    void CreateBuilding()
    {
        GameObject player = GameObject.Find("Player");
        GameObject g = Instantiate(buildingPref, buildingObj.transform);
        g.transform.localScale = new Vector3(1.5f, 1.3f, 1.5f);
        g.transform.Rotate(0, -89.7f, 0);
        Vector3 playerpos = player.transform.position;
        g.transform.position = new Vector3(-12, 0, playerpos.z + 10.0f);
        Vector3 createdObj = g.transform.position;
    }
}
