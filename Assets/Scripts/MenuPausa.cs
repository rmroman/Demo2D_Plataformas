using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Roberto Mtz. Román
 * Para manejar el comportamiento de la Pausa
 */
public class MenuPausa : MonoBehaviour
{
    [SerializeField]
    private GameObject menuPausa;

    public bool estaPausado = false;

    public void Pausar()
    {
        estaPausado = !estaPausado;
        menuPausa.SetActive(estaPausado);
        Time.timeScale = estaPausado ? 0.5f : 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausar();
        }
    }
}
