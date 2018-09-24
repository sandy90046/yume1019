using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour {
    private Animator anim;
    private Collider col;
    // Use this for initialization
    void Awake() {
        col = GetComponent<Collider>();
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col) {
        anim.SetTrigger("hit");
    }
}
