using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedra : MonoBehaviour {
    private GameObject player;
    private GameObject score;


    private void Start() {
        player = GameObject.Find("Alien");
        score = GameObject.Find("Game Manager");
        transform.Rotate(new Vector3(-73.26801f, -181.324f, 165.855f));
    }
        
    private void Update() {

        transform.Rotate(new Vector3(0f, 150f * Time.deltaTime * 1, 1f * Time.deltaTime * 1));
    }
    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.CompareTag("Player")) {
            player.GetComponent<PlayerMoviment>().pedras += 1;
            score.GetComponent<score>().AddPedra();
            Destroy(gameObject);
        }
    }
}
