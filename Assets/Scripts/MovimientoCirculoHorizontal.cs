using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovimientoCirculoHorizontal : MonoBehaviour
{

    //1. Declaración de variables
    [Range(1, 10)] public float velocidad; //Velocidad del jugador
    Rigidbody2D rb2d;
    SpriteRenderer spRd;


  
        void Start()
        {
            //2. Capturo y asocio los componentes Rigidbody2D y Sprite Renderer del Jugador
            rb2d = GetComponent<Rigidbody2D>();
            spRd = GetComponent<SpriteRenderer>();

        }

        void Update() //every frame...
        {
        //3. Movimiento horizontal
        float movimientoH = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(movimientoH * velocidad, rb2d.velocity.y);

        //4. Sentido horizontal (para girar el render del jugador)
        if (movimientoH > 0) // (Input.GetKey(KeyCode.LeftArrow))
        {
            //spRd.flipX = false;
           
            gameObject.transform.Rotate(0, 0, -1); //if the player is, then rotate counterclockwise in the x axis    
        }
        else if (movimientoH < 0) // (Input.GetKey(KeyCode.RightArrow))
        {
           // spRd.flipX = true;
           
            gameObject.transform.Rotate(0, 0, 1); //if he is, then rotate clockwise in the x axis
        }

        }


    }
