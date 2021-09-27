using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class armadilha : MonoBehaviour
{
    public int dano;
    public float intervaloDano;

    public abstract IEnumerator causarDano();

}
