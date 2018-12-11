using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CompleteProject
{

    public class WeaponButton : MonoBehaviour
    {
        public PlayerCombat playerCombat;
        public int weaponNumber;

        public Text name;
        public Text cost;
        public Text description;

        private AudioSource source;

        // Use this for initialization
        void Start()
        {
            source = GetComponent<AudioSource>();
            SetButton();

        }

        void SetButton()
        {
            //string costString = playerCombat.weapons[weaponNumber].cost.ToString();
            name.text = playerCombat.weapons[weaponNumber].name;
            cost.text = "$" + playerCombat.weapons[weaponNumber].cost;
            description.text = playerCombat.weapons[weaponNumber].description;
        }

        public void OnClick()
        {
            if (playerCombat.currency >= playerCombat.weapons[weaponNumber].cost)
            {
                playerCombat.currency -= playerCombat.weapons[weaponNumber].cost;
                playerCombat.currentWeapon = weaponNumber;
            }

            else 
            {
                source.Play();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}