using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakable : MonoBehaviour
{
    public int objectLife = 3;


    private void Update() {
        
        if( objectLife <= 0) {
            Destroy(gameObject);
        }
    }

}
