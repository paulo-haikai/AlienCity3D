using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{

    public Transform balaPoint;
    public GameObject arma;

    // Start is called before the first frame update
    void Start()
    {
        balaPoint = GameObject.Find("tiro").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Instantiate(arma, balaPoint.position, balaPoint.rotation);
        }
        }
    }



