﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class creditos : MonoBehaviour
{
      public string mudaCena;


    public void Changes() {

        SceneManager.LoadScene(mudaCena);
    }
}
