using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IDropHandler
{
    private Clothing clothing;

    void Awake()
    {
        clothing = GetComponent<Clothing>();
    }
    public GameObject item
    {

        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }
    public void OnDrop(PointerEventData eventData)
    {
        //Lands on Person 
        CheckSlot();
    }

    private void CheckSlot()
    {
        //Checks if slots are avalible and names the content
        if (DragHandler.itemBeingDragged.name.StartsWith(this.gameObject.name) && DragHandler.itemBeingDragged.tag == "Under" //correct slot & underpants
            || this.gameObject.name == "Slots" && !item //inventory slot
            || DragHandler.itemBeingDragged.name.StartsWith(this.gameObject.name) && item //underpants on & correct slot
            || DragHandler.itemBeingDragged.name.StartsWith(this.gameObject.name) && DragHandler.itemBeingDragged.tag == "Solo")//no underpants required
        {
            //Debug.Log(DragHandler.itemBeingDragged.name);
            Debug.Log(this.gameObject.name);
            DragHandler.itemBeingDragged.transform.SetParent(transform);
        }
    }
}
