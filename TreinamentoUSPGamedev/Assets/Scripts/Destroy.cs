using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public float destruction_time = 0.15f;
	void Start () {
        Destroy(gameObject, destruction_time);
	}
	
	void Update () {
		
	}
}
