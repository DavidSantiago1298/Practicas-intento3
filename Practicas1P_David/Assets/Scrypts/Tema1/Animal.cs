using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string Name = "Animal";

    public virtual void Display()
    {
        Debug.Log("El animal se llama: " + Name);
    }
}