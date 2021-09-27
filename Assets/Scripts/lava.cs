using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lava : armadilha
{
    private GameObject player;
    private bool tocandoLava;
    private bool tomaDano = true;
    public lava() {
        dano = 20;
        intervaloDano = 20f;

    }

    private void Start() {
        player = (GameObject.Find("Alien"));
    }

    private void Update() {
        if (tocandoLava && tomaDano) {
            tomaDano = false;
            StartCoroutine("causarDano");

        }
    }

    private void OnTriggerEnter(Collider col) {
        if(col.gameObject.CompareTag("Player")) {
            tocandoLava = true;
        }
    }
    private void OnTriggerExit(Collider col) {
        if (col.gameObject.CompareTag("Player")) {
            tocandoLava = false;
            

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
