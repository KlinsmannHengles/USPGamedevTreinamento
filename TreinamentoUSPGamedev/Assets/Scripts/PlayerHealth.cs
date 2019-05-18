using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public int health;
    public Image heart1;
    public Image heart2;
    public Image heart3;
    public Image heart4;
    public Image heart5;
    public Image heart6;
    public Image heart7;

	// Use this for initialization
	void Start () {
        heart4.enabled = false;
        heart5.enabled = false;
        heart6.enabled = false;
        heart7.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (health == 6)
        {
            heart7.enabled = false;
        }
        else if (health == 5)
        {
            heart6.enabled = false;
        }
        else if (health == 4)
        {
            heart5.enabled = false;
        }
        else if (health == 3)
        {
            heart4.enabled = false;
        }
        else if (health == 2)
        {
            heart3.enabled = false;
        }
        else if (health == 1)
        {
            heart2.enabled = false;
        }
        else if (health == 0) {
            heart1.enabled = false;
            Destroy(gameObject, .1f);

        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 1;
        }
        
    }

}
