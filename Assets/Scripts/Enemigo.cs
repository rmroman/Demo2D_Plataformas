using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Roberto Martínez Román
 * Verifica la colisión del Enemigo con el personaje.
 */
public class Enemigo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Descontar UNA vida
            SaludPersonaje.instance.vidas--;
            HUD.instance.ActualizarVidas();

            if (SaludPersonaje.instance.vidas == 0)
            {
                Destroy(collision.gameObject, 0.1f);
            }
        }
    }
}
