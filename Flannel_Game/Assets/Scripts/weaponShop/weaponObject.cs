using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class weaponObject : ScriptableObject {

    public string weaponName = "Name";
    public int cost = 10;
    public string description;


    public int damage = 2;
}
