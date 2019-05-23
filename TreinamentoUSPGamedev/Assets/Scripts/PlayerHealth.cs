using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public int health; // pontos de saúde do jogador
    public int heart_max; // número máximo de corações disponível
    public int old_heart_max; // número anterior de corações disponível

    // imagens de coração vazio
    public Image heart_empty1;
    public Image heart_empty2;
    public Image heart_empty3;
    public Image heart_empty4;
    public Image heart_empty5;
    public Image heart_empty6;
    public Image heart_empty7;

    // imagens de coração cheio
    public Image heart_full1;
    public Image heart_full2;
    public Image heart_full3;
    public Image heart_full4;
    public Image heart_full5;
    public Image heart_full6;
    public Image heart_full7;

    public Text youdied;

    // Use this for initialization
    void Start () {

        // o jogador começa com o número de 3 corações disponíveis e cheios
        heart_max = 3;

        // por isso as outras imagens de coração são desabilitadas da interface
        heart_empty4.enabled = false;
        heart_empty5.enabled = false;
        heart_empty6.enabled = false;
        heart_empty7.enabled = false;
        heart_full4.enabled = false;
        heart_full5.enabled = false;
        heart_full6.enabled = false;
        heart_full7.enabled = false;

        youdied.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {

        TakeDamage();
        Take_HeartMax();

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Se colidir com um objeto que tenha a  tag "Enemy" vai perder 1 de vida
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 1;
        }

        // se colidir com um objeto que tenha a tag "Heart_Max" ele  vai ganhar um coração máximo
        if (collision.gameObject.tag == "Heart_Max")
        {
            // o máximo de corações possível é 7, por isso depois que heart_max alcança 7, essa variável não aumenta mais
            if (heart_max < 7)
            {
                heart_max += 1;
            }  
        }

        if (collision.gameObject.tag == "Heart")
        {
            Take_Heart();
        }
        
    }

    // pegar coração que aumenta a vida do player
    public void Take_Heart ()
    {
        if (health == 1)
        {
            health += 1;
            heart_full2.enabled = true;
        }
        else if (health == 2)
        {
            health += 1;
            heart_full3.enabled = true;
        }
        else if (health == 3 && heart_max > 3)
        {
            health += 1;
            heart_full4.enabled = true;
        }
        else if (health == 4 && heart_max > 4)
        {
            health += 1;
            heart_full5.enabled = true;
        }
        else if (health == 5 && heart_max > 5)
        {
            health += 1;
            heart_full6.enabled = true;
        }
        else if (health == 6 && heart_max > 6)
        {
            health += 1;
            heart_full7.enabled = true;
        }
    }

    // quando o player pega o coração que adiciona slots, a imagem de um novo coração vazio aparece na interface
    public void Take_HeartMax ()
    {
        // se houve alteração no número de corações máximo (ver na colisão com "Heart_Max") um novo slot é adicionado
        if (old_heart_max != heart_max)
        {
            old_heart_max += 1;
            
            if (heart_max == 4)
            {
                heart_empty4.enabled = true;
            }
            else if (heart_max == 5)
            {
                heart_empty5.enabled = true;
            }
            else if (heart_max == 6)
            {
                heart_empty6.enabled = true;
            }
            else if (heart_max == 7)
            {
                heart_empty7.enabled = true;
            }

        }
    }

    // função de tirar a vida do player de acordo com os pontos de vida as imagens de coração são desabilitadas
    public void TakeDamage ()
    {
        if (health == 6)
        {
            heart_full7.enabled = false;
        }
        else if (health == 5)
        {
            heart_full6.enabled = false;
        }
        else if (health == 4)
        {
            heart_full5.enabled = false;
        }
        else if (health == 3)
        {
            heart_full4.enabled = false;
        }
        else if (health == 2)
        {
            heart_full3.enabled = false;
        }
        else if (health == 1)
        {
            heart_full2.enabled = false;
        }
        else if (health == 0)
        {
            heart_full1.enabled = false;
            Destroy(gameObject, .1f);
            youdied.enabled = true;
        }

    }

}
