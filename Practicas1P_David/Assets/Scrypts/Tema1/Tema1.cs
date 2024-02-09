using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema1 : MonoBehaviour
{
    //VARIABLES GLOBALES
    public int edad = 25;

    // Start is called before the first frame update
    void Start()
    {
        //VARIABLES LOCALES
        int resultado = suma(5, 5);
        Debug.Log("El resultado es: " + resultado);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void walk(/*parametros*/)
    {

    }

    int suma(int x, int y)
    {
        return x + y;
    }
}