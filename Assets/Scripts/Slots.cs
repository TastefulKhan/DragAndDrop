using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IDropHandler
{

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
        if (!item && DragHandler.itemBeingDragged.name == this.gameObject.name || !item && this.gameObject.name == "Slots")
        {
            //Debug.Log(DragHandler.itemBeingDragged.name);
            //Debug.Log(this.gameObject.name);
            DragHandler.itemBeingDragged.transform.SetParent(transform);
        }
    }
}
