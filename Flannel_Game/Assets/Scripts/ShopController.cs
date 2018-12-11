using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour {

    public GameObject shopPanel;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            OpenShop();
        }
    }

    void OpenShop()
    {
        shopPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseShop()
    {
        shopPanel.SetActive(false);
        Time.timeScale = 1;
    }

}
