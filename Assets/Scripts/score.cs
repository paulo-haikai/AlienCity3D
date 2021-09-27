using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;
    public Text scorePedra;
    public int ponto = 0;
    public int pedra = 0;
    

    // Start is called before the first frame update
    private void Start()
    {
        scoreText.text = " ";
        scorePedra.text = " ";

       

    }

    // Update is called once per frame
    public void AddChave() {
        ponto += 1;
        scoreText.text = ponto.ToString();
    }
    public void AddPedra() {
        pedra += 1;
        scorePedra.text = pedra.ToString();
        
        


    }
}
