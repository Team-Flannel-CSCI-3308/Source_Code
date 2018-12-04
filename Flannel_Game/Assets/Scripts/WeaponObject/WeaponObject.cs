using System.Collections;
using UnityEngine;

[System.Serializable]
public class WeaponObject : ScriptableObject {

    public string weaponName = "WeaponName";
    public int cost = 10;
    public string description;

    public int damage = 2;

}
