using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CombatManager : MonoBehaviour {

    public GameObject player;
    public GameObject enemy;

    public Button attackButton;

    public int turn; // 0 for player
                     // 1 for enemy
    public Text turnText;

    public Text playerHealth;
    public Text enemyHealth;


    // Use this for initialization
    void Start() {
        attackButton.onClick.AddListener(PlayerAttack);
        turn = 0;
    }

    // Update is called once per frame
    void Update() {
        if (player.GetComponent<PlayerCombat>().health > 0 && enemy.GetComponent<EnemyCombat>().health > 0) {
            switch (turn) {
                case 0:
                    turnText.text = "Player's turn";
                    attackButton.gameObject.SetActive(true);
                    break;
                case 1:
                    turnText.text = "Enemy's turn";
                    attackButton.gameObject.SetActive(false);
                    EnemyAttack();
                    break;
                default:
                    break;
            }
        } else if (enemy.GetComponent<EnemyCombat>().health <= 0) {
            // we have defeated the enemy
            SceneManager.LoadScene("main");
        }

        // TODO: change total health to not be hardcoded
        playerHealth.text = "Player Health: " + player.GetComponent<PlayerCombat>().health.ToString() + "/10";
        enemyHealth.text = "Enemy Health: " + enemy.GetComponent<EnemyCombat>().health.ToString() + "/5";
    }

    void PlayerAttack() {
        enemy.GetComponent<EnemyCombat>().health -= player.GetComponent<PlayerCombat>().attack;
        Debug.Log("Player attacked enemy for " + player.GetComponent<PlayerCombat>().attack + " health");
        turn = 1;
    }

    void EnemyAttack() {
        player.GetComponent<PlayerCombat>().health -= enemy.GetComponent<EnemyCombat>().attack;
        Debug.Log("Enemy attacked player for " + enemy.GetComponent<EnemyCombat>().attack + " health");
        turn = 0;
    }

}
