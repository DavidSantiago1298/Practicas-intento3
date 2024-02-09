using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad = 2f;

    void Update()
    {
        // permite usar el teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Da el movimiento
        Vector3 direccion = new Vector3(movimientoHorizontal, 0f, movimientoVertical).normalized;

        // Mover el personaje en la dirección deseada
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }
}