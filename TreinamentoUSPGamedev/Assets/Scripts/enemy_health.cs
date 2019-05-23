using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_health : MonoBehaviour
{

    public int maxhealth = 5, currenthealth; void Start()
    {
        currenthealth = maxhealth;
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        if (currenthealth <= 0)
        {
            Destroy(gameObject);
        }
    }



    void Update()
    {

    }
}
