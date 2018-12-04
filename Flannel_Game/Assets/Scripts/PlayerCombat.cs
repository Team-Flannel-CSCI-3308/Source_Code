using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CompleteProject
{

    public class PlayerCombat : MonoBehaviour
    {

        public int health, attack, currency;

        public WeaponObject[] weapons;
        public int currentWeapon = 0;

        // Use this for initialization
        void Start()
        {
            health = 10;

            attack = weapons[currentWeapon].damage;

            currency = 25;
        }
    }
}