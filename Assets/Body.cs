using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Body : MonoBehaviour
{
    public GameObject text;
    public GameObject body;
    private Transform head;
    private Transform torso;
    private Transform legs;
    private Transform feet;



    void Update()
    {
        CheckBody();
    }

    void Awake()
    {
        body = this.gameObject;
        head = this.gameObject.transform.GetChild(0);
        torso = this.gameObject.transform.GetChild(1);
        legs = this.gameObject.transform.GetChild(2);
        feet = this.gameObject.transform.GetChild(3);
        //Debug.Log(torso);

    }

    private bool CheckBody()
    {
        if (head.childCount > 0 && torso.childCount > 0 && legs.childCount > 0 && feet.childCount > 0)
        {
            Debug.Log("Checked!");
            return true;
        }
        else {
            return false;
        }
    }
}