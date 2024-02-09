using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class BallBase : MonoBehaviour
{ 
 public string Name = "Ball";
public float speed = 5f;
public float AreaDetection = 2f;
public Vector3 MousePosition;

public virtual void move()
{
    if (Input.GetMouseButtonDown(0))
    {
        //Accedemos a la posicion del mouse
        MousePosition =
Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z = 0f;
    }

    //Calculamos la direccion
    Vector3 direction = (MousePosition - transform.position).normalized;

    //Mover al objeto a la direccion calculada
    transform.Translate(direction * speed * Time.deltaTime);
}
}