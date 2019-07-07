using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDetect : MonoBehaviour {

public AudioClip sound1;
    public int hitcnt = 0;

AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update () {
		
	}
    public void OnTriggerEnter(Collider other){
        audioSource.PlayOneShot(sound1);
        Destroy(other.gameObject);
        hitcnt++;
        if (hitcnt > 4){
            SceneManager.LoadScene("Result");
        }
    }
}
