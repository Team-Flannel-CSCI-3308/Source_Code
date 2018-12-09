using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerCombat : MonoBehaviour
    {

        public int health, attack;
        public int money;
        public weaponObject[] weapons;
        public int currentWeapon = 0;

        // Use this for initialization
        void Start()
        {
            money = 20;
            health = 10;
            // attack = weapons[currentWeapon].damage;
        }

        // Update is called once per frame
        void Update()
        {

        }

    }
