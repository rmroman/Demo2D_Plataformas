using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private AudioSource efectoMoneda;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.3f);  // Destruye la MONEDA

            // Contar la moneda recolectada
            SaludPersonaje.instance.monedas++;
            // Actualizar el texto del contador
            HUD.instance.ActualizarMonedas();
            // Reproduce efecto de tomar la moneda
            efectoMoneda.Play();
        }
    }
}
