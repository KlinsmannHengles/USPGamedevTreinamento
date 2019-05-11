using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public int health;
    public Image hearth1;
    public Image hearth2;
    public Image hearth3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (health == 2)
        {
            hearth3.enabled = false;
        } else if (health == 1) {
            hearth2.enabled = false;
        } else if (health == 0) {
            hearth1.enabled = false;
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
