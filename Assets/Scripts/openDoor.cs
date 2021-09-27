using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {

    public Animator anim;
    private bool tocaPorta = false;
    private bool podeAbrir = false;
    private GameObject player;
    private PlayerMoviment jogador;
    public int chaves;

    // Start is called before the first frame update
    void Start() {
        player = GameObject.Find("Alien");
        
        
    }
    public void maisChave() {

        chaves += 1;

    }
    // Update is called once per frame
    void Update() {


    }


    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {

            tocaPorta = true;

            if (chaves == 2) {
                podeAbrir = true;
            }
            if (tocaPorta && podeAbrir)
                anim.SetInteger("abertura", 1);
        }



   
    }
}




            

        
    




