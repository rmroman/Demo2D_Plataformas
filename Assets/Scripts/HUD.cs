using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{
    // 3 imágenes (corazones)
    [SerializeField]  // Para accederlo desde Unity
    private Image imagen1;
    [SerializeField]  // Para accederlo desde Unity
    private Image imagen2;
    [SerializeField]  // Para accederlo desde Unity
    private Image imagen3;

    // Contador de monedas
    [SerializeField]
    private TextMeshProUGUI txtMonedas;

    public static HUD instance;

    public void ActualizarVidas()
    {
        int vidas = SaludPersonaje.instance.vidas;
        switch (vidas)
        {
            case 2:
                imagen3.enabled = false;
                break;
            case 1:
                imagen2.enabled = false;
                break;
            case 0:
                imagen1.enabled = false;
                break;
        }
    }

    internal void ActualizarMonedas()
    {
        int monedas = SaludPersonaje.instance.monedas;
        txtMonedas.text = monedas.ToString();
    }

    private void Awake()
    {
        instance = this;
    }
}
