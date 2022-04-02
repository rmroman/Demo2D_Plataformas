using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jugar()
    {
        // Cargar la escena de Mario
        SceneManager.LoadScene("EscenaMapa");
    }
}
