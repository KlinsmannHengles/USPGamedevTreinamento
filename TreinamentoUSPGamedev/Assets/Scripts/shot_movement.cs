using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Este script é responsável não apenas por movimentar a bola de fogo como, também, destruí-la e criar o efeito de impacto ao atingir algum gameobject.
public class shot_movement : MonoBehaviour
{
    public GameObject enemy;
    public int damage = 1;
    //velocidade publica da bola de fogo.
    public float shotspeed = 20f;
    //rigidbody da bola de fogo.
    public Rigidbody2D rb;
    //Gameobject relativo ao efeito de explosão do impacto do tiro em alguma outra superfície.
    public GameObject impactexplosion;

    void Start()
    {
        //Inicia a movimentação da bola de fogo.
        rb.velocity = transform.right * shotspeed;

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //apresenta na tela o objeto q foi atingido pela bola de fogo, destrói a bola de fogo e cria o efeito de explosão do impacto.
        Debug.Log(hitInfo.name);
        if (hitInfo.name == "Enemy")
        {
            hitInfo.gameObject.GetComponent<enemy_health>().TakeDamage(damage);
             Instantiate(impactexplosion, transform.position, transform.rotation);
        }
        Destroy(gameObject);
    }


}
