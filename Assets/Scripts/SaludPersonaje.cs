using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Roberto Mtz. Román
 * Almacena la salud del personaje
 */
public class SaludPersonaje : MonoBehaviour
{
    public int vidas = 3;
    public int monedas = 0;

    public static SaludPersonaje instance;

    private void Awake()
    {
        instance = this;
    }
}
