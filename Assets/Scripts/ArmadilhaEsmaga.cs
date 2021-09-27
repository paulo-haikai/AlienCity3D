using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmadilhaEsmaga : armadilha {
    private GameObject player;
    private bool tocandoPedra;
    private bool tomaDano = true;
    

    public ArmadilhaEsmaga() {

        dano = 20;
        intervaloDano = 20f;

    }

    private void Start() {
        player = (GameObject.Find("Alien"));
    }

    private void Update() {
        if (tocandoPedra && tomaDano) {
            tomaDano = false;
            StartCoroutine("causarDano");

        }
    }

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.CompareTag("Player")) {
            tocandoPedra = true;
        }
    }
    private void OnTriggerExit(Collider col) {
        if (col.gameObject.CompareTag("Player")) {
            tocandoPedra = false;


        }
    }
    public override IEnumerator causarDano() {
        //player.GetComponent<PlayerMoviment>().life -= dano;
        player.GetComponent<PlayerMoviment>().tomaDano(dano);
        yield return new WaitForSeconds(intervaloDano);
        tomaDano = true;
        Debug.Log("Vida do jogador: " + player.GetComponent<PlayerMoviment>().life);
    }
}
