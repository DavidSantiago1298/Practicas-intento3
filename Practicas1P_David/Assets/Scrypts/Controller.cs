using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private bool InventoryEnabled;

    public GameObject inventory;

    private int allSlots;

    private int enabledSlots;

    private GameObject[] slot;

    public GameObject slotHolder;
    //Hace que los slots aguanten a los hijos que sean generados y puedan almazenarlos
    void Start()
    {
        allSlots = slotHolder.transform.childCount;

        slot = new GameObject[allSlots];

        for (int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

            if (slot[i].GetComponent<Slot>().item == null)
            {
                slot[i].GetComponent<Slot>().empty = true;
            }
        }
    }

    //Permite que al presionar la tecla i, se abra el inventario o se cierre
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            InventoryEnabled = !InventoryEnabled;
        }

        if ( InventoryEnabled == true)
        {
            inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }
    }

    //permite que el tag del item sea reconocido

    private void OnTriggerEnter(Collider other)
    {
            if (other.tag=="Item")
        {
            GameObject itemPickedup = other.gameObject;

            Item item = itemPickedup.GetComponent<Item>();

            AddItem(itemPickedup, item.ID, item.Type, item.descripcion,item.icon);
        }
    }
    //LLama al metodo de item para que reciban la info los slots
    public void AddItem(GameObject itemObject, int itemID, string itemType, string itemDescription, Sprite itemIcon)
    {
        for (int i = 0; i < allSlots; i++)
        {
            //EL [i[ permite que varios slots se almacenen y de esa manera el slot sabe si puede colocar un objeto o no
            if (slot[1].GetComponent<Slot>().empty)
            {
                //Confirma si se adquirio el item
                itemObject.GetComponent<Item>().pickedUp = true;

                //Pasa la info del item al slot

                slot[i].GetComponent<Slot>().item = itemObject;
                slot[i].GetComponent<Slot>().ID = itemID;
                slot[i].GetComponent<Slot>().type = itemType;
                slot[i].GetComponent<Slot>().description = itemDescription; ;
                slot[i].GetComponent<Slot>().icon= itemIcon;

                itemObject.transform.parent = slot[i].transform;
                itemObject.SetActive(false);

                slot[i].GetComponent<Slot>().UpdateSlot();

                slot[i].GetComponent<Slot>().empty = false;
            }
            return;
        }
    }
}
