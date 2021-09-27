using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class trocaCena : MonoBehaviour
{

    public string mudaCena;

    public void changes() {

        SceneManager.LoadScene(mudaCena);
    }
   
}
