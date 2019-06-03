using System.Collections.Generic;
using UnityEngine;

//Esta função serve para fazer com que, ao apertar w, a, s ou d, o personagem vire para esta direção e atire uma bola de fogo que segue, também, nessa direção.

public class Shot : MonoBehaviour
{
    //FirePoint é o ponto relativo ao player de onde a bola de fogo sairá.
    public Transform firepoint_right, firepoint_left, firepoint_up, firepoint_down;
    //Faz referência ao prefab da bola de fogo.
    public GameObject shotprefab;
    private float next_Shot = 0.0f;
    public float fire_Rate = 0.5f;



    void Update()
    {
        /*dependendo da direção escolhida e de se o tempo minimo para o próximo tiro já passou, instancia um tiro que segue na direção apontada até colidir
        com um objeto.*/
        if ((Input.GetKey("w")) && (Time.time > next_Shot))
        {
            next_Shot = Time.time + fire_Rate;
            shoot(firepoint_up);
        }
        if ((Input.GetKey("d")) && (Time.time > next_Shot))
        {
            next_Shot = Time.time + fire_Rate;
            shoot(firepoint_right);
        }
        if ((Input.GetKey("a")) && (Time.time > next_Shot))
        {
            next_Shot = Time.time + fire_Rate;
            shoot(firepoint_left);
        }
        if ((Input.GetKey("s")) && (Time.time > next_Shot))
        {
            next_Shot = Time.time + fire_Rate;
            shoot(firepoint_down);
        }
    }
    void shoot(Transform firepoint)
    //A função shoot instancia (ou seja, cria) uma gameobject de uma bola de fogo que segue na direção apra a qual o player está virado.
    {
        Instantiate(shotprefab, firepoint.position, firepoint.rotation);
    }
}
