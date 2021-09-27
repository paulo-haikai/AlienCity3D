using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keys : MonoBehaviour
{
    private GameObject player;
    private GameObject score;
    private GameObject open;


    private void Start() {
        player = GameObject.Find("Alien");
        score = GameObject.Find("Game Manager");
        open = GameObject.Find("Porta");
    }

    private void Update() {
        transform.Rotate(new Vector3(0f, 150f * Time.deltaTime * 1, Time.deltaTime * 1));
    }
    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.CompareTag("Player")) {
            player.GetComponent<PlayerMoviment>().chaves += 1;
            score.GetComponent<score>().AddChave();
            open.GetComponent<openDoor>().maisChave();
           
            Destroy(gameObject);
        }
    }
}
