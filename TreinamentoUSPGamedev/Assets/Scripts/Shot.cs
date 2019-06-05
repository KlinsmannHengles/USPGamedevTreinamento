using System.Collections.Generic;
using UnityEngine;

//Esta função serve para fazer com que, ao apertar w, a, s ou d, o personagem vire para esta direção e atire uma bola de fogo que segue, também, nessa direção.

public class Shot : MonoBehaviour
{
    //FirePoint é o ponto relativo ao player de onde a bola de fogo sairá.
    public Transform firepoint_right, firepoint_left, firepoint_up, firepoint_down;
    //Faz referência ao prefab da bola de fogo.
    public GameObject shotprefab;



    void Update()
    {
        /*dependendo da tecla apertada,  escolhe uma direrã para virar o npersonagem usando "quaternions", que são próprios para usar na rotação.
         * Além disso, chama a função shoot que é responsãvel por criar e lançar o projétil na direção para a qual o personagem estávirado.*/
        if (Input.GetKeyDown("w"))
        {
            shoot(firepoint_up);
        }
        if (Input.GetKeyDown("d"))
        {
            shoot(firepoint_right);
        }
        if (Input.GetKeyDown("a"))
        {
            shoot(firepoint_left);
        }
        if (Input.GetKeyDown("s"))
        {
            shoot(firepoint_down);
        }
    }
    void shoot(Transform firepoint)
    //A função shoot instancia (ou seja, cria) uma gameobject de uma bola de fogo que segue na direção apra a qual o player está virado.
    {
        Instantiate(shotprefab, firepoint.position, firepoint.rotation);
    }
}
