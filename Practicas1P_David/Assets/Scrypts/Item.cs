using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //Permite que el item sea detectado y tenga id, tipo, descripcion e icono
    public int ID;
    public string Type;
    public string descripcion;
    public Sprite icon;

    [HideInInspector]
    public bool pickedUp;
}
