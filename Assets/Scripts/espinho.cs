using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espinho : armadilha {
   
    private GameObject player;
    private bool tocandoEspinho;
    private bool tomaDano = true;

    



    public espinho() {
        dano = 10;
        intervaloDano = 20f;
    }
    private void start() {

        player = GameObject.Find("Alien");
        
       
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {

            tocandoEspinho = true;
           

        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
           tocandoEspinho = false;
            
    }
    }



    private void Update() {
        if (tocandoEspinho && tomaDano) {
            tomaDano = true;
            StartCoroutine("causarDano");

        }
    }

    
   
    public override IEnumerator causarDano() {
        //player.GetComponent<PlayerMoviment>().life -= dano;
        //player.GetComponent<PlayerMoviment>().life -= dano;
        // player.GetComponent<PlayerMoviment>().tomaDano(dano);

        //player.GetComponent<PlayerMoviment>().tomaDano(dano);
        player.GetComponent<PlayerMoviment>().tomaDano(dano);
        yield return new WaitForSeconds(intervaloDano);
        tomaDano = true;
        Debug.Log("Vida do jogador: " + player.GetComponent<PlayerMoviment>().life);
    }

       

        }
    





