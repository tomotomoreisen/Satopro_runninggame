using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour {

    public Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        InvokeRepeating("SpeedUpAnim", 1 , 5);
	}
	
    void SpeedUpAnim()
    {
     
        //anim["Crouching"].speed = cruchspeed;
    }
  
}
