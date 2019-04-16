using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 50f;

    public float horizontalMove = 0f;
    public float verticalMove = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

    void FixedUpdate () {

        horizontalMove = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        verticalMove = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        Move();

    }

    public void Move () {

        transform.Translate(horizontalMove, verticalMove, 0f);

    }
}
