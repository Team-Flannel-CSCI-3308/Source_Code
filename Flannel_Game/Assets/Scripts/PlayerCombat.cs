using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerCombat : MonoBehaviour
    {

        public int health, attack;
        public int currency;
        public WeaponObject[] weapons;
        public int currentWeapon = 0;

        // Use this for initialization
        void Start()
        {
            currency = 20;
            health = 10;
            attack = weapons[currentWeapon].damage;
        }

        // Update is called once per frame
        void Update()
        {

        }

    }
