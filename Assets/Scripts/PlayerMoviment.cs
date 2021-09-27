using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMoviment : MonoBehaviour
{
    public float speed = 100f;
    public float CameraRotation = 30f;
    public float pulo;
    private CharacterController cc;
    private Camera minhaCamera;
    private bool jump = false;
    private Vector3 gravidade;
    public Animator anim;
    public int chaves;
    public int life = 100;
    public int vidaAtual;
    public int pedras;
    public barraVida barraVida;
    public string mudaCena;
    private PlayerMoviment player;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        minhaCamera = GetComponent<Camera>();
        barraVida = GetComponent<barraVida>();
        vidaAtual = life;
        barraVida.vidaMaxima(vidaAtual);
        player = GetComponent<PlayerMoviment>();
   
    }


    // Update is called once per frame
    void Update()
    {
       
            

        Vector3 movement = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * speed;
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * CameraRotation * Time.deltaTime, 0));

        movement += gravidade;
        cc.Move(movement * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space)) {
            
            jump = true;            
            
        }


        if (life <= 1) {


            anim.SetTrigger("vida");
            SceneManager.LoadScene("derrota");
            

        }
        

        if (!cc.isGrounded) {
            gravidade += Physics.gravity * Time.deltaTime;
        }
           else {
            gravidade = Vector3.zero;
            if (jump) {
                gravidade.y = pulo;
                jump = false;
                
            }

        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            anim.Play("Pulo"); 
        }
        else anim.SetTrigger("parado");
        
        if (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.DownArrow)) || (Input.GetKey(KeyCode.S))))
            {
            anim.SetInteger("corrida", 1);
        }
        else
            anim.SetInteger("corrida", 0);

       // if (Input.GetKey(KeyCode.P)) {

            //minhaCamera.transform.position
       // }
    }


    public void change() {

        SceneManager.LoadScene(mudaCena);
    }
    public void tomaDano(int dano) {

        vidaAtual -= dano; // altera a vida no player
        barraVida.mudaVida(vidaAtual); // altera o visual
    }

    }
    
    

        

