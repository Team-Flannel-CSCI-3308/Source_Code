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

	// Use this for initialization
	void Start () {
        attackButton.onClick.AddListener(PlayerAttack);

        turn = 0;
	}

    // Update is called once per frame
    void Update() {
        if (player.GetComponent<PlayerCombat>().health != 0 && enemy.GetComponent<EnemyCombat>().health != 0) { 
            switch(turn) {
                case 0:
                    turnText.text = "Player's turn";
                    attackButton.gameObject.SetActive(true);
                    attackButton.onClick.AddListener(PlayerAttack);
                    if (Input.GetMouseButtonDown(0))
                        turn++;
                    break;
                case 1:
                    turnText.text = "Enemy's turn";
                    attackButton.gameObject.SetActive(false);
                    EnemyAttack();
                    turn--;
                    break;
                default:
                    break;
            }
        } else if (enemy.GetComponent<EnemyCombat>().health == 0) {
            // we have defeated the enemy
            SceneManager.LoadScene("main");
        }   
	}

    void PlayerAttack() {
        enemy.GetComponent<EnemyCombat>().health -= player.GetComponent<PlayerCombat>().attack;
        Debug.Log("Player attacked enemy for " + player.GetComponent<PlayerCombat>().attack + " health");
    }

    IEnumerator EnemyAttack() {
        player.GetComponent<PlayerCombat>().health -= enemy.GetComponent<EnemyCombat>().attack;
        Debug.Log("Enemy attacked player for " + enemy.GetComponent<EnemyCombat>().attack + " health");
        yield return new WaitForSeconds(3f);
    }

   
}
