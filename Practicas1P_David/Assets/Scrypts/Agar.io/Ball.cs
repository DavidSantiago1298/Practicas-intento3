using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : BallBase
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    public override void move()
    {
        MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z = 0f;
        Vector3 direction = (MousePosition - transform.position).normalized;

        transform.Translate(direction * speed * Time.deltaTime);
    }
}