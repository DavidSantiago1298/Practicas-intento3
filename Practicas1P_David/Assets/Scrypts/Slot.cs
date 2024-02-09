using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    //Permite que los slots reciban la informacion y puedan mostras los sprites de los iconos de las comiditas
    public GameObject item;
    public int ID;
    public string type;
    public string description;

    public bool empty;
    public Sprite icon;

    public Transform slotIconGameObject;

    private void Start()
    {
        slotIconGameObject = transform.GetChild(0);
    }

    public void UpdateSlot()
    {
        this.GetComponent<Image>().sprite = icon;
    }
}
