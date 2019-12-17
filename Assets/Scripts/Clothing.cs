using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothing : MonoBehaviour
{
    public class Equip
    {
        public string Name;
        public bool Underpants = false;
        public Equip(string name)
        {
            Name = name;
        }
    }
    private void Start()
    {
        //Assigning Clothing Objects Attributes and Methods
        Equip equip = new Equip(this.gameObject.name);
        //Debug.Log(equip.Name);
        if(equip.Name=="Underpants")
            {
                equip.Underpants = true;
                Debug.Log(equip.Name + equip.Underpants);
            }
    }



}