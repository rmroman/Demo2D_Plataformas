using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{
    // Variable de instancia
    private Rigidbody2D rb;

    // Animator
    private Animator animator;

    // Sprite Renderer
    private SpriteRenderer sprRenderer;

    // Velocidad
    public float velocidadX = 0;
    public float velocidadY = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();    // Diagrama de estados
        sprRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        // Caminar
        float movHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movHorizontal * velocidadX, rb.velocity.y);
        // Salto
        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, movVertical * velocidadY);
        }
        // Animación
        float velocidad = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("velocidad", velocidad);
        // Dirección
        sprRenderer.flipX = rb.velocity.x < 0;
        // Animación de Saltando
        animator.SetBool("saltando", !PruebaPiso.estaEnPiso);
    }
}
