﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public float velocidade;

	private Transform target;

	// Use this for initialization
	void Start () {
		target =  GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position =  Vector2.MoveTowards(transform.position, target.position, velocidade*Time.deltaTime);
	}
}
