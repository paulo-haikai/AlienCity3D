using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class vitoria : MonoBehaviour
{
    public string mudaCena;


    public void Change() {

        SceneManager.LoadScene(mudaCena);
    }
}

